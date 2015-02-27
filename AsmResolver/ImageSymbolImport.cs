﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmResolver
{
    public class ImageSymbolImport
    {
        internal static ImageSymbolImport FromReadingContext(ReadingContext context)
        {
            var reader = context.Reader;
            var application = context.Assembly;

            var optionalHeader = application.NtHeaders.OptionalHeader;

            var import = new ImageSymbolImport(optionalHeader.Magic == OptionalHeaderMagic.Pe32Plus
                ? reader.ReadUInt64()
                : reader.ReadUInt32());

            if (import.Lookup == 0)
                return import;

            import.IsImportByOrdinal = import.Lookup >> (optionalHeader.Magic == OptionalHeaderMagic.Pe32Plus ? 63 : 31) == 1;
            
            if (!import.IsImportByOrdinal)
                import.HintName =
                    HintName.FromReadingContext(context.CreateSubContext(application.RvaToFileOffset(import.HintNameRva)));
    
            return import;
        }

        private ImageSymbolImport(ulong lookup)
        {
            Lookup = lookup;
        }

        public ImageSymbolImport(HintName hintName)
        {
            IsImportByOrdinal = false;
            HintName = hintName;
        }

        public ImageSymbolImport(ushort ordinal)
        {
            IsImportByOrdinal = true;
            Ordinal = ordinal;
        }

        public ulong Lookup
        {
            get;
            private set;
        }

        public ushort Ordinal
        {
            get { return (ushort)(!IsImportByOrdinal ? 0 : (Lookup & 0xFFFF)); }
            set { Lookup = unchecked((ulong)(long.MinValue | value)); }
        }

        public uint HintNameRva
        {
            get { return (uint)(IsImportByOrdinal ? 0 : (Lookup & 0x7FFFFFFFF)); }
        }

        public bool IsImportByOrdinal
        {
            get;
            set;
        }

        public HintName HintName
        {
            get;
            set;
        }

        public ImageModuleImport Module
        {
            get;
            internal set;
        }

        public ulong GetTargetAddress(bool is32Bit)
        {
            if (Module == null)
                return 0;
            return Module.GetSymbolImportAddress(this, is32Bit);
        }

        public override string ToString()
        {
            var prefix = Module == null ? string.Empty : Module.Name + "!";
            if (IsImportByOrdinal)
                return prefix + '#' + Ordinal.ToString("X");
            return prefix + HintName.Name;
        }
    }
}

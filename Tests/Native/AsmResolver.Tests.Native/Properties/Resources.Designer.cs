﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsmResolver.Tests.Native.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AsmResolver.Tests.Native.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Misc {
            get {
                object obj = ResourceManager.GetObject("Misc", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to use32
        ///
        ///das
        ///daa
        ///aas
        ///aaa
        ///
        ///inc eax
        ///inc ecx
        ///inc edx
        ///inc ebx
        ///inc esp
        ///inc ebp
        ///inc esi
        ///inc edi
        ///
        ///dec eax
        ///dec ecx
        ///dec edx
        ///dec ebx
        ///dec esp
        ///dec ebp
        ///dec esi
        ///dec edi
        ///
        ///push eax
        ///push ecx
        ///push edx
        ///push ebx
        ///push esp
        ///push ebp
        ///push esi
        ///push edi
        ///
        ///pop eax
        ///pop ecx
        ///pop edx
        ///pop ebx
        ///pop esp
        ///pop ebp
        ///pop esi
        ///pop edi
        ///
        ///pushad
        ///popad
        ///
        ///push 0x1337
        ///push 0x15
        ///
        ///nop
        ///xchg ecx, eax
        ///xchg edx, eax
        ///xchg ebx, eax
        ///xchg esp, eax
        ///xchg ebp, eax
        ///xchg esi, eax
        ///xchg edi, eax
        ///
        ///cwde
        ///cdq
        ///
        ///wait
        ///pus [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Misc_source {
            get {
                return ResourceManager.GetString("Misc_source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] OpCodeRegisterToken {
            get {
                object obj = ResourceManager.GetObject("OpCodeRegisterToken", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to use32
        ///
        ///add byte [0x1337], 0x1
        ///or byte [0x1337], 0x2
        ///adc byte [0x1337], 0x3
        ///sbb byte [0x1337], 0x4
        ///and byte [0x1337], 0x5
        ///sub byte [0x1337], 0x6
        ///xor byte [0x1337], 0x7
        ///cmp byte [0x1337], 0x8
        ///
        ///add dword [0x1337], 0x1337
        ///or dword [0x1337], 0x1337
        ///adc dword [0x1337], 0x1337
        ///sbb dword [0x1337], 0x1337
        ///and dword [0x1337], 0x1337
        ///sub dword [0x1337], 0x1337
        ///xor dword [0x1337], 0x1337
        ///cmp dword [0x1337], 0x1337.
        /// </summary>
        internal static string OpCodeRegisterToken_source {
            get {
                return ResourceManager.GetString("OpCodeRegisterToken_source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Reg8_RegOrMem8 {
            get {
                object obj = ResourceManager.GetObject("Reg8_RegOrMem8", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to use32
        ///
        ///add al, byte [eax]
        ///add al, byte [ecx]
        ///add al, byte [edx]
        ///add al, byte [ebx]
        ///add al, byte [esp]
        ///add al, byte [0x1337]
        ///add al, byte [esi]
        ///add al, byte [edi]
        ///
        ///add cl, byte [eax]
        ///add cl, byte [ecx]
        ///add cl, byte [edx]
        ///add cl, byte [ebx]
        ///add cl, byte [esp]
        ///add cl, byte [0x1337]
        ///add cl, byte [esi]
        ///add cl, byte [edi]
        ///
        ///add dl, byte [eax]
        ///add dl, byte [ecx]
        ///add dl, byte [edx]
        ///add dl, byte [ebx]
        ///add dl, byte [esp]
        ///add dl, byte [0x1337]
        ///add dl, byte [esi]
        ///add dl, byte [edi]
        ///
        ///add bl,  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Reg8_RegOrMem8_source {
            get {
                return ResourceManager.GetString("Reg8_RegOrMem8_source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] RegOrMem8_Reg8 {
            get {
                object obj = ResourceManager.GetObject("RegOrMem8_Reg8", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] RegOrMem8_Reg8_sib {
            get {
                object obj = ResourceManager.GetObject("RegOrMem8_Reg8_sib", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to use32
        ///
        ///add byte [eax+eax], al
        ///add byte [eax+ecx], al
        ///add byte [eax+edx], al
        ///add byte [eax+ebx], al
        ///add byte [eax+ebp], al
        ///add byte [eax+esi], al
        ///add byte [eax+edi], al
        ///
        ///add byte [eax+eax*2], al
        ///add byte [eax+ecx*2], al
        ///add byte [eax+edx*2], al
        ///add byte [eax+ebx*2], al
        ///add byte [eax+ebp*2], al
        ///add byte [eax+esi*2], al
        ///add byte [eax+edi*2], al
        ///
        ///add byte [eax+eax*4], al
        ///add byte [eax+ecx*4], al
        ///add byte [eax+edx*4], al
        ///add byte [eax+ebx*4], al
        ///add byte [eax+ebp*4], al
        ///add byte [eax+esi*4 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RegOrMem8_Reg8_sib_source {
            get {
                return ResourceManager.GetString("RegOrMem8_Reg8_sib_source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to use32
        ///
        ///add byte [eax], al
        ///add byte [ecx], al
        ///add byte [edx], al
        ///add byte [ebx], al
        ///add byte [esp], al
        ///add byte [0x1337], al
        ///add byte [esi], al
        ///add byte [edi], al
        ///
        ///add byte [eax], cl
        ///add byte [ecx], cl
        ///add byte [edx], cl
        ///add byte [ebx], cl
        ///add byte [esp], cl
        ///add byte [0x1337], cl
        ///add byte [esi], cl
        ///add byte [edi], cl
        ///
        ///add byte [eax], dl
        ///add byte [ecx], dl
        ///add byte [edx], dl
        ///add byte [ebx], dl
        ///add byte [esp], dl
        ///add byte [0x1337], dl
        ///add byte [esi], dl
        ///add byte [edi], dl
        ///
        ///add byte [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RegOrMem8_Reg8_source {
            get {
                return ResourceManager.GetString("RegOrMem8_Reg8_source", resourceCulture);
            }
        }
    }
}

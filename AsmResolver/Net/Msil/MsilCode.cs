﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable InconsistentNaming

namespace AsmResolver.Net.Msil
{
    public enum MsilCode
    {
        // taken from System.Reflection.Emit.OpCodeValues

        Nop,
        Break,
        Ldarg_0,
        Ldarg_1,
        Ldarg_2,
        Ldarg_3,
        Ldloc_0,
        Ldloc_1,
        Ldloc_2,
        Ldloc_3,
        Stloc_0,
        Stloc_1,
        Stloc_2,
        Stloc_3,
        Ldarg_S,
        Ldarga_S,
        Starg_S,
        Ldloc_S,
        Ldloca_S,
        Stloc_S,
        Ldnull,
        Ldc_I4_M1,
        Ldc_I4_0,
        Ldc_I4_1,
        Ldc_I4_2,
        Ldc_I4_3,
        Ldc_I4_4,
        Ldc_I4_5,
        Ldc_I4_6,
        Ldc_I4_7,
        Ldc_I4_8,
        Ldc_I4_S,
        Ldc_I4,
        Ldc_I8,
        Ldc_R4,
        Ldc_R8,
        Dup = 37,
        Pop,
        Jmp,
        Call,
        Calli,
        Ret,
        Br_S,
        Brfalse_S,
        Brtrue_S,
        Beq_S,
        Bge_S,
        Bgt_S,
        Ble_S,
        Blt_S,
        Bne_Un_S,
        Bge_Un_S,
        Bgt_Un_S,
        Ble_Un_S,
        Blt_Un_S,
        Br,
        Brfalse,
        Brtrue,
        Beq,
        Bge,
        Bgt,
        Ble,
        Blt,
        Bne_Un,
        Bge_Un,
        Bgt_Un,
        Ble_Un,
        Blt_Un,
        Switch,
        Ldind_I1,
        Ldind_U1,
        Ldind_I2,
        Ldind_U2,
        Ldind_I4,
        Ldind_U4,
        Ldind_I8,
        Ldind_I,
        Ldind_R4,
        Ldind_R8,
        Ldind_Ref,
        Stind_Ref,
        Stind_I1,
        Stind_I2,
        Stind_I4,
        Stind_I8,
        Stind_R4,
        Stind_R8,
        Add,
        Sub,
        Mul,
        Div,
        Div_Un,
        Rem,
        Rem_Un,
        And,
        Or,
        Xor,
        Shl,
        Shr,
        Shr_Un,
        Neg,
        Not,
        Conv_I1,
        Conv_I2,
        Conv_I4,
        Conv_I8,
        Conv_R4,
        Conv_R8,
        Conv_U4,
        Conv_U8,
        Callvirt,
        Cpobj,
        Ldobj,
        Ldstr,
        Newobj,
        Castclass,
        Isinst,
        Conv_R_Un,
        Unbox = 121,
        Throw,
        Ldfld,
        Ldflda,
        Stfld,
        Ldsfld,
        Ldsflda,
        Stsfld,
        Stobj,
        Conv_Ovf_I1_Un,
        Conv_Ovf_I2_Un,
        Conv_Ovf_I4_Un,
        Conv_Ovf_I8_Un,
        Conv_Ovf_U1_Un,
        Conv_Ovf_U2_Un,
        Conv_Ovf_U4_Un,
        Conv_Ovf_U8_Un,
        Conv_Ovf_I_Un,
        Conv_Ovf_U_Un,
        Box,
        Newarr,
        Ldlen,
        Ldelema,
        Ldelem_I1,
        Ldelem_U1,
        Ldelem_I2,
        Ldelem_U2,
        Ldelem_I4,
        Ldelem_U4,
        Ldelem_I8,
        Ldelem_I,
        Ldelem_R4,
        Ldelem_R8,
        Ldelem_Ref,
        Stelem_I,
        Stelem_I1,
        Stelem_I2,
        Stelem_I4,
        Stelem_I8,
        Stelem_R4,
        Stelem_R8,
        Stelem_Ref,
        Ldelem,
        Stelem,
        Unbox_Any,
        Conv_Ovf_I1 = 179,
        Conv_Ovf_U1,
        Conv_Ovf_I2,
        Conv_Ovf_U2,
        Conv_Ovf_I4,
        Conv_Ovf_U4,
        Conv_Ovf_I8,
        Conv_Ovf_U8,
        Refanyval = 194,
        Ckfinite,
        Mkrefany = 198,
        Ldtoken = 208,
        Conv_U2,
        Conv_U1,
        Conv_I,
        Conv_Ovf_I,
        Conv_Ovf_U,
        Add_Ovf,
        Add_Ovf_Un,
        Mul_Ovf,
        Mul_Ovf_Un,
        Sub_Ovf,
        Sub_Ovf_Un,
        Endfinally,
        Leave,
        Leave_S,
        Stind_I,
        Conv_U,
        Prefix7 = 248,
        Prefix6,
        Prefix5,
        Prefix4,
        Prefix3,
        Prefix2,
        Prefix1,
        Prefixref,
        Arglist = 65024,
        Ceq,
        Cgt,
        Cgt_Un,
        Clt,
        Clt_Un,
        Ldftn,
        Ldvirtftn,
        Ldarg = 65033,
        Ldarga,
        Starg,
        Ldloc,
        Ldloca,
        Stloc,
        Localloc,
        Endfilter = 65041,
        Unaligned,
        Volatile,
        Tail,
        Initobj,
        Constrained,
        Cpblk,
        Initblk,
        Rethrow = 65050,
        Sizeof = 65052,
        Refanytype,
        Readonly
    }
}

// ReSharper restore InconsistentNaming
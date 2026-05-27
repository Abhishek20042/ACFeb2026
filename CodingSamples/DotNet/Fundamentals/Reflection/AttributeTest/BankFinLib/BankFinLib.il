
//  .NET IL Disassembler.  Version 10.0.8



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly BankFinLib
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 19 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 31 30 2E 30 01 00 54 0E   // ersion=v10.0..T.
                                                                                                              14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61   // .FrameworkDispla
                                                                                                              79 4E 61 6D 65 09 2E 4E 45 54 20 31 30 2E 30 )    // yName..NET 10.0
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 0A 42 61 6E 6B 46 69 6E 4C 69 62 00 00 )    // ...BankFinLib..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 07 52 65 6C 65 61 73 65 00 00 )             // ...Release..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 32 2E 30 2E 30 2E 30 00 00 )             // ...2.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 32 2E 30 2E 30 00 00 )                   // ...2.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 0A 42 61 6E 6B 46 69 6E 4C 69 62 00 00 )    // ...BankFinLib..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 0A 42 61 6E 6B 46 69 6E 4C 69 62 00 00 )    // ...BankFinLib..
  .hash algorithm 0x00008004
  .ver 2:0:0:0
}
.module BankFinLib.dll
// MVID: {a798ef62-cac1-4125-8c7c-c1782388f17c}
.custom instance void [System.Runtime]System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x0x7114486c3000


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit Finance.CarLoan
       extends Finance.PersonalLoan
{
  .method public hidebysig virtual instance float32 
          Common(valuetype [System.Runtime]System.Decimal amount,
                 int32 period) cil managed
  {
    // Code size       31 (0x1f)
    .maxstack  8
    IL_0000:  ldarg.1
    IL_0001:  ldc.i4     0xf4240
    IL_0006:  newobj     instance void [System.Runtime]System.Decimal::.ctor(int32)
    IL_000b:  call       bool [System.Runtime]System.Decimal::op_LessThan(valuetype [System.Runtime]System.Decimal,
                                                                          valuetype [System.Runtime]System.Decimal)
    IL_0010:  brtrue.s   IL_0016

    IL_0012:  ldc.i4.s   12
    IL_0014:  br.s       IL_0018

    IL_0016:  ldc.i4.s   11
    IL_0018:  ldarg.2
    IL_0019:  ldc.i4.3
    IL_001a:  cgt
    IL_001c:  add
    IL_001d:  conv.r4
    IL_001e:  ret
  } // end of method CarLoan::Common

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void Finance.PersonalLoan::.ctor()
    IL_0006:  ret
  } // end of method CarLoan::.ctor

} // end of class Finance.CarLoan

.class public auto ansi beforefieldinit Finance.EducationLoan
       extends [System.Runtime]System.Object
{
  .method public hidebysig instance float32 
          Common(valuetype [System.Runtime]System.Decimal amount,
                 int32 period) cil managed
  {
    .custom instance void Finance.MaxDurationAttribute::.ctor(int32) = ( 01 00 05 00 00 00 00 00 ) 
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  ldc.r4     6
    IL_0005:  ret
  } // end of method EducationLoan::Common

  .method public hidebysig instance float32 
          Scholar(valuetype [System.Runtime]System.Decimal amount,
                  int32 period) cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  ldc.r4     4
    IL_0005:  ret
  } // end of method EducationLoan::Scholar

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  ret
  } // end of method EducationLoan::.ctor

} // end of class Finance.EducationLoan

.class public auto ansi beforefieldinit Finance.FlexibleAttribute
       extends [System.Runtime]System.Attribute
{
  .custom instance void [System.Runtime]System.AttributeUsageAttribute::.ctor(valuetype [System.Runtime]System.AttributeTargets) = ( 01 00 04 00 00 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method FlexibleAttribute::.ctor

} // end of class Finance.FlexibleAttribute

.class public auto ansi beforefieldinit Finance.HomeLoan
       extends [System.Runtime]System.Object
{
  .method public hidebysig instance float32 
          Common(valuetype [System.Runtime]System.Decimal amount,
                 int32 period) cil managed
  {
    // Code size       30 (0x1e)
    .maxstack  8
    IL_0000:  ldarg.1
    IL_0001:  ldc.i4     0x4c4b40
    IL_0006:  newobj     instance void [System.Runtime]System.Decimal::.ctor(int32)
    IL_000b:  call       bool [System.Runtime]System.Decimal::op_LessThan(valuetype [System.Runtime]System.Decimal,
                                                                          valuetype [System.Runtime]System.Decimal)
    IL_0010:  brtrue.s   IL_0018

    IL_0012:  ldc.r4     8
    IL_0017:  ret

    IL_0018:  ldc.r4     8.5
    IL_001d:  ret
  } // end of method HomeLoan::Common

  .method public hidebysig instance float32 
          Woman(valuetype [System.Runtime]System.Decimal amount,
                int32 period) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       instance float32 Finance.HomeLoan::Common(valuetype [System.Runtime]System.Decimal,
                                                                   int32)
    IL_0008:  ldc.r4     1
    IL_000d:  sub
    IL_000e:  ret
  } // end of method HomeLoan::Woman

  .method public hidebysig instance float32 
          Welfare(valuetype [System.Runtime]System.Decimal amount,
                  int32 period) cil managed
  {
    .custom instance void Finance.MaxDurationAttribute::.ctor(int32) = ( 01 00 05 00 00 00 01 00 54 08 05 4C 69 6D 69 74   // ........T..Limit
                                                                         0C 00 00 00 ) 
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldc.r4     0.60000002
    IL_0005:  ldarg.0
    IL_0006:  ldarg.1
    IL_0007:  ldarg.2
    IL_0008:  call       instance float32 Finance.HomeLoan::Common(valuetype [System.Runtime]System.Decimal,
                                                                   int32)
    IL_000d:  mul
    IL_000e:  ret
  } // end of method HomeLoan::Welfare

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  ret
  } // end of method HomeLoan::.ctor

} // end of class Finance.HomeLoan

.class public abstract auto ansi sealed beforefieldinit Finance.LoanHelper
       extends [System.Runtime]System.Object
{
  .method public hidebysig static valuetype [System.Runtime]System.Decimal 
          MonthlyInstallment(valuetype [System.Runtime]System.Decimal loan,
                             int32 years,
                             float32 rate) cil managed
  {
    // Code size       54 (0x36)
    .maxstack  4
    .locals init (int32 V_0,
             float32 V_1)
    IL_0000:  ldc.i4.s   12
    IL_0002:  ldarg.1
    IL_0003:  mul
    IL_0004:  stloc.0
    IL_0005:  ldarg.2
    IL_0006:  ldc.r4     1200
    IL_000b:  div
    IL_000c:  stloc.1
    IL_000d:  ldloc.1
    IL_000e:  conv.r8
    IL_000f:  ldc.r8     1
    IL_0018:  ldc.r4     1
    IL_001d:  ldloc.1
    IL_001e:  add
    IL_001f:  conv.r8
    IL_0020:  ldloc.0
    IL_0021:  neg
    IL_0022:  conv.r8
    IL_0023:  call       float64 [System.Runtime]System.Math::Pow(float64,
                                                                  float64)
    IL_0028:  sub
    IL_0029:  div
    IL_002a:  call       valuetype [System.Runtime]System.Decimal [System.Runtime]System.Decimal::op_Explicit(float64)
    IL_002f:  ldarg.0
    IL_0030:  call       valuetype [System.Runtime]System.Decimal [System.Runtime]System.Decimal::op_Multiply(valuetype [System.Runtime]System.Decimal,
                                                                                                              valuetype [System.Runtime]System.Decimal)
    IL_0035:  ret
  } // end of method LoanHelper::MonthlyInstallment

} // end of class Finance.LoanHelper

.class public auto ansi beforefieldinit Finance.MaxDurationAttribute
       extends [System.Runtime]System.Attribute
{
  .custom instance void [System.Runtime]System.AttributeUsageAttribute::.ctor(valuetype [System.Runtime]System.AttributeTargets) = ( 01 00 C0 00 00 00 01 00 54 02 09 49 6E 68 65 72   // ........T..Inher
                                                                                                                                     69 74 65 64 00 )                                  // ited.
  .field private int32 '<Limit>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] int32 'value') cil managed
  {
    .param [1] = int32(0x00000005)
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      int32 Finance.MaxDurationAttribute::'<Limit>k__BackingField'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [System.Runtime]System.Attribute::.ctor()
    IL_000d:  ret
  } // end of method MaxDurationAttribute::.ctor

  .method public hidebysig specialname instance int32 
          get_Limit() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Finance.MaxDurationAttribute::'<Limit>k__BackingField'
    IL_0006:  ret
  } // end of method MaxDurationAttribute::get_Limit

  .method public hidebysig specialname instance void 
          set_Limit(int32 'value') cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      int32 Finance.MaxDurationAttribute::'<Limit>k__BackingField'
    IL_0007:  ret
  } // end of method MaxDurationAttribute::set_Limit

  .property instance callconv(8) int32 Limit()
  {
    .get instance int32 Finance.MaxDurationAttribute::get_Limit()
    .set instance void Finance.MaxDurationAttribute::set_Limit(int32)
  } // end of property MaxDurationAttribute::Limit
} // end of class Finance.MaxDurationAttribute

.class public auto ansi beforefieldinit Finance.PersonalLoan
       extends [System.Runtime]System.Object
{
  .custom instance void Finance.FlexibleAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig newslot virtual 
          instance float32  Common(valuetype [System.Runtime]System.Decimal amount,
                                   int32 period) cil managed
  {
    .custom instance void Finance.MaxDurationAttribute::.ctor(int32) = ( 01 00 06 00 00 00 00 00 ) 
    // Code size       17 (0x11)
    .maxstack  8
    IL_0000:  ldc.r4     10
    IL_0005:  ldc.r4     0.5
    IL_000a:  ldarg.2
    IL_000b:  ldc.i4.3
    IL_000c:  div
    IL_000d:  conv.r4
    IL_000e:  mul
    IL_000f:  add
    IL_0010:  ret
  } // end of method PersonalLoan::Common

  .method public hidebysig instance float32 
          Employee(valuetype [System.Runtime]System.Decimal amount,
                   int32 period) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldc.r4     0.5
    IL_0005:  ldarg.0
    IL_0006:  ldarg.1
    IL_0007:  ldarg.2
    IL_0008:  callvirt   instance float32 Finance.PersonalLoan::Common(valuetype [System.Runtime]System.Decimal,
                                                                       int32)
    IL_000d:  mul
    IL_000e:  ret
  } // end of method PersonalLoan::Employee

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  ret
  } // end of method PersonalLoan::.ctor

} // end of class Finance.PersonalLoan


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************

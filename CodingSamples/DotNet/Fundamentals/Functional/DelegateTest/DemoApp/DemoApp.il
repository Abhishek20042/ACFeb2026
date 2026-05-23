
//  .NET IL Disassembler.  Version 10.0.8



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly DemoApp
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 19 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 31 30 2E 30 01 00 54 0E   // ersion=v10.0..T.
                                                                                                              14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61   // .FrameworkDispla
                                                                                                              79 4E 61 6D 65 09 2E 4E 45 54 20 31 30 2E 30 )    // yName..NET 10.0
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module DemoApp.dll
// MVID: {9db4efcd-e5b2-45fe-9050-2e4702b65a19}
.custom instance void [System.Runtime]System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x0x723250b3a000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed Interest
       extends [System.Runtime]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(object 'object',
                               native int 'method') runtime managed
  {
  } // end of method Interest::.ctor

  .method public hidebysig newslot virtual 
          instance float32  Invoke(int32 period) runtime managed
  {
  } // end of method Interest::Invoke

  .method public hidebysig newslot virtual 
          instance class [System.Runtime]System.IAsyncResult 
          BeginInvoke(int32 period,
                      class [System.Runtime]System.AsyncCallback callback,
                      object 'object') runtime managed
  {
  } // end of method Interest::BeginInvoke

  .method public hidebysig newslot virtual 
          instance float32  EndInvoke(class [System.Runtime]System.IAsyncResult result) runtime managed
  {
  } // end of method Interest::EndInvoke

} // end of class Interest

.class private auto ansi beforefieldinit Investment
       extends [System.Runtime]System.Object
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RequiredMemberAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private initonly float64 '<Installment>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private initonly int32 '<Years>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .method public hidebysig specialname instance float64 
          get_Installment() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      float64 Investment::'<Installment>k__BackingField'
    IL_0006:  ret
  } // end of method Investment::get_Installment

  .method public hidebysig specialname instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) 
          set_Installment(float64 'value') cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      float64 Investment::'<Installment>k__BackingField'
    IL_0007:  ret
  } // end of method Investment::set_Installment

  .method public hidebysig specialname instance int32 
          get_Years() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Investment::'<Years>k__BackingField'
    IL_0006:  ret
  } // end of method Investment::get_Years

  .method public hidebysig specialname instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) 
          set_Years(int32 'value') cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      int32 Investment::'<Years>k__BackingField'
    IL_0007:  ret
  } // end of method Investment::set_Years

  .method public hidebysig instance float64 
          FutureValue(class Interest rate) cil managed
  {
    // Code size       65 (0x41)
    .maxstack  3
    .locals init (float32 V_0,
             float64 V_1)
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldarg.0
    IL_0003:  call       instance int32 Investment::get_Years()
    IL_0008:  callvirt   instance float32 Interest::Invoke(int32)
    IL_000d:  ldc.r4     100
    IL_0012:  div
    IL_0013:  stloc.0
    IL_0014:  ldarg.0
    IL_0015:  call       instance float64 Investment::get_Installment()
    IL_001a:  ldloc.0
    IL_001b:  conv.r8
    IL_001c:  div
    IL_001d:  ldc.r4     1
    IL_0022:  ldloc.0
    IL_0023:  add
    IL_0024:  conv.r8
    IL_0025:  ldarg.0
    IL_0026:  call       instance int32 Investment::get_Years()
    IL_002b:  conv.r8
    IL_002c:  call       float64 [System.Runtime]System.Math::Pow(float64,
                                                                  float64)
    IL_0031:  ldc.r8     1
    IL_003a:  sub
    IL_003b:  mul
    IL_003c:  stloc.1
    IL_003d:  br.s       IL_003f

    IL_003f:  ldloc.1
    IL_0040:  ret
  } // end of method Investment::FutureValue

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .custom instance void [System.Runtime]System.ObsoleteAttribute::.ctor(string,
                                                                          bool) = ( 01 00 5F 43 6F 6E 73 74 72 75 63 74 6F 72 73 20   // .._Constructors 
                                                                                    6F 66 20 74 79 70 65 73 20 77 69 74 68 20 72 65   // of types with re
                                                                                    71 75 69 72 65 64 20 6D 65 6D 62 65 72 73 20 61   // quired members a
                                                                                    72 65 20 6E 6F 74 20 73 75 70 70 6F 72 74 65 64   // re not supported
                                                                                    20 69 6E 20 74 68 69 73 20 76 65 72 73 69 6F 6E   //  in this version
                                                                                    20 6F 66 20 79 6F 75 72 20 63 6F 6D 70 69 6C 65   //  of your compile
                                                                                    72 2E 01 00 00 )                                  // r....
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute::.ctor(string) = ( 01 00 0F 52 65 71 75 69 72 65 64 4D 65 6D 62 65   // ...RequiredMembe
                                                                                                                              72 73 00 00 )                                     // rs..
    // Code size       23 (0x17)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.r8     50000
    IL_000a:  stfld      float64 Investment::'<Installment>k__BackingField'
    IL_000f:  ldarg.0
    IL_0010:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0015:  nop
    IL_0016:  ret
  } // end of method Investment::.ctor

  .property instance callconv(8) float64 Installment()
  {
    .get instance float64 Investment::get_Installment()
    .set instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) Investment::set_Installment(float64)
  } // end of property Investment::Installment
  .property instance callconv(8) int32 Years()
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.RequiredMemberAttribute::.ctor() = ( 01 00 00 00 ) 
    .get instance int32 Investment::get_Years()
    .set instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) Investment::set_Years(int32)
  } // end of property Investment::Years
} // end of class Investment

.class private auto ansi beforefieldinit DemoApp.Program
       extends [System.Runtime]System.Object
{
  .class abstract auto ansi sealed nested private beforefieldinit '<>O'
         extends [System.Runtime]System.Object
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public static class Interest '<0>__SafeScheme'
  } // end of class '<>O'

  .class auto ansi sealed nested private beforefieldinit '<>c__DisplayClass1_0'
         extends [System.Runtime]System.Object
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public int32 m
    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       8 (0x8)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
      IL_0006:  nop
      IL_0007:  ret
    } // end of method '<>c__DisplayClass1_0'::.ctor

    .method assembly hidebysig instance float32 
            '<Main>b__0'(int32 y) cil managed
    {
      // Code size       17 (0x11)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldfld      int32 DemoApp.Program/'<>c__DisplayClass1_0'::m
      IL_0006:  conv.r4
      IL_0007:  ldc.r4     0.25
      IL_000c:  ldarg.1
      IL_000d:  conv.r4
      IL_000e:  mul
      IL_000f:  add
      IL_0010:  ret
    } // end of method '<>c__DisplayClass1_0'::'<Main>b__0'

  } // end of class '<>c__DisplayClass1_0'

  .method private hidebysig static float32 
          SafeScheme(int32 count) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  2
    .locals init (float32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldc.i4.3
    IL_0003:  blt.s      IL_0008

    IL_0005:  ldc.i4.7
    IL_0006:  br.s       IL_0009

    IL_0008:  ldc.i4.6
    IL_0009:  conv.r4
    IL_000a:  stloc.0
    IL_000b:  br.s       IL_000d

    IL_000d:  ldloc.0
    IL_000e:  ret
  } // end of method Program::SafeScheme

  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       164 (0xa4)
    .maxstack  4
    .locals init (class DemoApp.Program/'<>c__DisplayClass1_0' V_0,
             float64 V_1,
             int32 V_2,
             class Investment V_3)
    IL_0000:  newobj     instance void DemoApp.Program/'<>c__DisplayClass1_0'::.ctor()
    IL_0005:  stloc.0
    IL_0006:  nop
    IL_0007:  ldstr      "Installment    : "
    IL_000c:  call       void [System.Console]System.Console::Write(string)
    IL_0011:  nop
    IL_0012:  call       string [System.Console]System.Console::ReadLine()
    IL_0017:  call       float64 [System.Runtime]System.Double::Parse(string)
    IL_001c:  stloc.1
    IL_001d:  ldstr      "Number of Years: "
    IL_0022:  call       void [System.Console]System.Console::Write(string)
    IL_0027:  nop
    IL_0028:  call       string [System.Console]System.Console::ReadLine()
    IL_002d:  call       int32 [System.Runtime]System.Int32::Parse(string)
    IL_0032:  stloc.2
    IL_0033:  newobj     instance void Investment::.ctor()
    IL_0038:  dup
    IL_0039:  ldloc.1
    IL_003a:  callvirt   instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) Investment::set_Installment(float64)
    IL_003f:  nop
    IL_0040:  dup
    IL_0041:  ldloc.2
    IL_0042:  callvirt   instance void modreq([System.Runtime]System.Runtime.CompilerServices.IsExternalInit) Investment::set_Years(int32)
    IL_0047:  nop
    IL_0048:  stloc.3
    IL_0049:  ldstr      "Future value in riskless investment: {0:0.00}"
    IL_004e:  ldloc.3
    IL_004f:  ldsfld     class Interest DemoApp.Program/'<>O'::'<0>__SafeScheme'
    IL_0054:  dup
    IL_0055:  brtrue.s   IL_006a

    IL_0057:  pop
    IL_0058:  ldnull
    IL_0059:  ldftn      float32 DemoApp.Program::SafeScheme(int32)
    IL_005f:  newobj     instance void Interest::.ctor(object,
                                                       native int)
    IL_0064:  dup
    IL_0065:  stsfld     class Interest DemoApp.Program/'<>O'::'<0>__SafeScheme'
    IL_006a:  callvirt   instance float64 Investment::FutureValue(class Interest)
    IL_006f:  box        [System.Runtime]System.Double
    IL_0074:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_0079:  nop
    IL_007a:  ldloc.0
    IL_007b:  ldc.i4.8
    IL_007c:  stfld      int32 DemoApp.Program/'<>c__DisplayClass1_0'::m
    IL_0081:  ldstr      "Future value in riskful investment : {0:0.00}"
    IL_0086:  ldloc.3
    IL_0087:  ldloc.0
    IL_0088:  ldftn      instance float32 DemoApp.Program/'<>c__DisplayClass1_0'::'<Main>b__0'(int32)
    IL_008e:  newobj     instance void Interest::.ctor(object,
                                                       native int)
    IL_0093:  callvirt   instance float64 Investment::FutureValue(class Interest)
    IL_0098:  box        [System.Runtime]System.Double
    IL_009d:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_00a2:  nop
    IL_00a3:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class DemoApp.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************

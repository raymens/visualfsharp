// #Regression #Diagnostics 
// Regression test for FSHARP1.0:3596
// Make sure that error spans correctly across multiple lines
//<Expects status="warning" id="FS0020" span="(8,1-10,18)">This expression should have type 'unit'</Expects>
#nowarn "988"
let f g x = g x

f (fun x ->

             x) 3

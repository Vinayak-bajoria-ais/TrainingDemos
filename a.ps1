try
{
"enter the first integer"
[int]$a= Read-Host
if(($a -ne [int]))
{

}
else
{
throw  "a is not integer."
}
"enter the second integer"
[int]$b= Read-Host
if(($b -is [int]))
{

}
elseif($b -eq 0)
{
throw "Arithmetic exception"
}
else
{
throw  "b is not integer."
}
[float]$c=$a/$b
Write-Host $c
}
catch
{
Write-Host $_.Exception.Message
}
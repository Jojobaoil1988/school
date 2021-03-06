###########################
#Jannis Guhl
#16.03.2011
#syslog.ps1
###########################

####### Funktionen ########

function logfile ($name)
{
    Get-EventLog -after 16.03.2011 -logname $name | Select-Object timegenerated, message, source
}

logfile("system") | ConvertTo-Html | Out-File "C:\Users\Administrator\Documents\Powershell-Skripte\log.html"
logfile("application") | ConvertTo-Html | Out-File -append "C:\Users\Administrator\Documents\Powershell-Skripte\log.html"
logfile("security") | ConvertTo-Html | Out-File -append "C:\Users\Administrator\Documents\Powershell-Skripte\log.html"

C:\Users\Administrator\Documents\Powershell-Skripte\log.html
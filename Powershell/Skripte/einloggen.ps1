#Jannis Guhl
#23.03.2011
#Einloggen im Google-Account per Skript
#einloggen.ps1

$ie = New-Object -ComObject InternetExplorer.Application

$ie.navigate("http://www.google.de")
$ie.visible = "true"
while($ie.busy)
{
    sleep 1
}
$linkliste = $ie.Document.getElementByID("gb_70")
foreach ($link in $linkliste)
{
    if($linkliste.innerHTML -eq "Anmelden")
    {
        $link.click()
    }
}
#$eingabe = $ie.Document.getelementbyID("Email")
#$eingabe.value = "Jannis.Guhl"
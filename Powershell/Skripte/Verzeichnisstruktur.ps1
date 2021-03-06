#Jannis Guhl
#23.03.2011
#Automatisches Erstellen einer Verzeichnisstruktur
#Verzeichnisstruktur.ps1

"Bitte geben Sie den Pfad zur Schülerliste ein:"
$pfad=read-host "Pfad: "

$inhalt = Import-Csv $pfad -delimiter ";"

if (($inhalt | Select-Object Klasse) -like "*Klasse*")
{
    ForEach ($zeile in $inhalt)
    {
        $klasse = $zeile | Select-Object Klasse -unique
        mkdir -path C:\tmp\Schueler\ -name $klasse.Klasse -ErrorAction:silentlycontinue
        $zeile | %(cd c:\tmp\schueler; cd $_.Klasse; mkdir -path c:\tmp\schueler\BE081 -name $_.Name + "," + $_.Vorname)
    }
}
else
{
    "Dies ist keine gültige Datei!"
}
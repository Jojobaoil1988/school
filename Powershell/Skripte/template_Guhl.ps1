##############################
#Jannis Guhl
#16.03.2011
#Groesse_verzeichnis.ps1
##############################


######## Funktionen ##########

function liefergroesse ($liste)
{
    #lokale Variablen
    $summe = 0
    
    #Addieren der Groessen
    $liste|Foreach-Object {$summe += $_.length} 
    
    return $summe / 1MB
    
}

######## Hauptprogramm ########

$ordnerliste1 = dir -recurse -force C:\Windows #Erstellung der Dateiliste #-force zählt versteckte Dateien mit

Write-Host Ordner C:\Windows: (liefergroesse($ordnerliste1)) MB

$ordnerliste2 = dir -recurse -force C:\"Program Files" #Erstellung der Dateiliste #-force zählt versteckte Dateien mit

Write-Host Ordner C:\Program Files: (liefergroesse($ordnerliste2)) MB
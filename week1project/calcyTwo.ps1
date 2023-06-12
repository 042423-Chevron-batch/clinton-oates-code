$totalPoints = Read-Host -Prompt "What is  the total number of points?"
$score = Read-Host -Prompt "What will your username be?"
$percent = (($score/$totalPoints) *100)
$grade=""

if ($percent -gt 90){
    $grade="A"
}
elseif (($percent -le 90) -and ($percent -gt 80)) {
    $grade="B"
}
elseif (($percent -le 80) -and (-gt 70)){
    $grade="C"
}
elseif (($percent -le 70) -and (-gt 60)) {
    $grade="D"
}
else  {
    $grade="F"
}

Param(
	[Switch]$ToClipboard
)

$utc = (Get-Date).ToUniversalTime()
$timestamp = [System.Math]::Floor((Get-Date -Date $utc -UFormat %s))
if ($ToClipboard -eq $true ) { $timestamp | Set-Clipboard }
return $timestamp
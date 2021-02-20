<?php
header('Content-Type: application/json');
//Request GET.

$status["information"] = "Request Information";
$status["oldmodz95"] = "Request OldModz95";
$status["discord"] = "https://discord.gg/3t2568W";


//$status = prefix
//information = information result
//"result information" = message send to result information.

echo json_encode($status);
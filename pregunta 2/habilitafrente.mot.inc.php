<?php
session_start();
$nombre=$_SESSION["usuario"];
  $sql_c="update academico324.alumno set nombre='".$nombre."' where ci=12";
 $resultado_c=mysqli_query($conn, $sql_c);

?>
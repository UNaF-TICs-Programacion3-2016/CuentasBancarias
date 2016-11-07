<?php
//cuentas bancarias
class CuentaBancaria{
    //atributos
	private $Banco;
	private $Numero_Cuenta;
	private $CBU;
	private$Tipo_Cuenta;

	//agregar cuenta bancaria
	public function agregarCuentaBancaria($banco,$numero_cuenta,$cbu,$tipoCuenta){
	  	$this->Banco         = $banco;
		$this->Numero_Cuenta = $numero_cuenta;
		$this->CBU           = $cbu;
		$this->Tipo_Cuenta   = $tipoCuenta;
	}
}



//clase cuenta persona
class Persona{
	//atributos de las personas
	private  $Apellido;
	private  $Nombre;
	//private  $datos_persona_array = [{'Nombre':'','Apellido':''}];
	/*private $Direccion;
	private $Cuil;
	private $Telefono;
	private $Sexo;*/
	public  $CuentasBancarias; //atributo para la composicion entre las clases

	//constructores set value a los atributos
	public function __construct($nombre,$apellido){
	  $this->Apellido         = $apellido;
	  $this->Nombre           = $nombre;
	  $this->CuentasBancarias = array();
	}


	
	//get datos persona
	public function getDataPersona(){
		return array('Nombre'=>$this->Nombre,'Apellido'=>$this->Apellido);
	}

	public function getCuentasBancarias(){
	  return  $this->CuentasBancarias;
	}
		
}

//instanciamos persona
$persona1 = new Persona("Alexis","Qui?onez");
//cuenta bancaria uno
$cuenta_bancaria1 = new CuentaBancaria();
$cuenta_bancaria1->agregarCuentaBancaria('Galicia',212212132132,143433422343421321,'Corriente');
//agregamos la cuenta
$persona1->CuentasBancarias[] = $cuenta_bancaria1;

//add cuenta bancaria dos
$cuenta_bancaria2 = new CuentaBancaria();
$cuenta_bancaria2->agregarCuentaBancaria('Banco Formosa',212212132132,143433422343143423,'Caja de ahorro');
//agregamos la cuenta
$persona1->CuentasBancarias[] = $cuenta_bancaria2;
// composicion del objeto
echo "<pre>";
print_r($persona1);
echo "</pre>";
?>
<!DOCTYPE html>
<html>
	<head>
		<title>Persona - Cuenta Bancaria</title>
		<meta charset="UTF-8"/>
		<link rel="stylesheet" type="text/css" href="style.css">
	</head>
		<body>
			<form method="post" action="fieldset.html">
				<fieldset>
					<legend>Persona - Cuenta Bancaria</legend>
					<div>
						<label for="fullname">Personas:</label>
						<select>
							<option>
								Nombre y Apellido
							</option>					
						</select>
					</div>
				<div>
					<label for="email">Cuentas Bancarias:</label>
					<textarea></textarea>
				</div>
			</form>
		</body>
	</head>
</html>

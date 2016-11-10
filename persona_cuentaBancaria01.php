<?php
//cuentas bancarias
class CuentaBancaria{
    //atributos
	private $Banco;
	private $Numero_Cuenta;
	private $CBU;
	private $Tipo_Cuenta;

	//set atributos
	public function __construct($banco,$numero_cuenta,$cbu,$tipo_cuenta){
	  //set atributos
	  $this->Banco         = $banco;
	  $this->Numero_Cuenta = $numero_cuenta;
	  $this->CBU           = $cbu;
	  $this->Tipo_Cuenta   = $tipo_cuenta;
	}

	//return  cuentas
	public function getCuentaBanco(){
	  	return $this->Banco." - ".$this->Tipo_Cuenta;
	}
	
}



//clase cuenta persona
class Persona{
	//atributos de las personas
	private  $Apellido;
	private  $Nombre;
	private  $Direccion;
	private  $Cuil;
	private  $Telefono;
	private  $Sexo;
	private  $CuentasBancarias = array(); //atributo para la composicion entre las clases

	//metodo set atributos datos de Persona
	public function registrarDatosPersona($apellido,$nombre,$direccion,$cuil,$telefono,$sexo){
	  	$this->Apellido  = $apellido;
		$this->Nombre    = $nombre;
	   	$this->Direccion = $direccion;
		$this->Cuil      = $cuil;
		$this->Telefono  = $telefono;
		$this->Sexo      = $sexo;		
	}

	//add cuenta Persona
	public function agregarCuentaBancaria($banco,$numero_cuenta,$cbu,$tipo_cuenta){	
		$this->CuentasBancarias[] = new CuentaBancaria($banco,$numero_cuenta,$cbu,$tipo_cuenta);
	}

	//get cuenta Person
	public function getCuentasPersona(){
		foreach($this->CuentasBancarias as $cuentas){
			echo $cuentas->getCuentaBanco()."\n";
		}
	}

	//return array datos Persona
	public function getDataPersona(){
		return array('Apellido'=>$this->Apellido,'Nombre'=>$this->Nombre);
	}
	
		
}

//instanciamos persona
$oPersona = new Persona();
//registramos una persona
$oPersona->registrarDatosPersona('Quionez','Alexis','Ayacucho 23432',213231221332,"3704-1221321","m");
//registramos cuentas para esa persona
$oPersona->agregarCuentaBancaria("Hipotecario",2,212321332213132,"Corriente");
$oPersona->agregarCuentaBancaria("Galicia",3,213123123321132,"Caja de Ahorro");

//vemos como esta compuesto internamente el objeto
//var_dump($oPersona);
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
								<?php
									foreach($oPersona->getDataPersona() as $datos){
										echo $datos." ";
									}
								?>
							</option>					
						</select>
					</div>
				<div>
					<label for="email">Cuentas Bancarias:</label>
					<textarea>
					<?php
						$oPersona->getCuentasPersona();
					?>
					</textarea>
				</div>
			</form>
		</body>
	</head>
</html>

// Inheritance function
Function.prototype.inherit = function(parent){
	this.prototype = new parent();
	this.prototype.constructor = parent;
}

// Extending functionality function
Function.prototype.extend = function(parent) {
    for (var i = 1; i < arguments.length; i += 1) {
        var name = arguments[i];
        this.prototype[name] = parent.prototype[name];
    }
    return this;
}

function PropulsionUnit(){
}

PropulsionUnit.prototype.acceleration = function(){
}

// constructor of propulsion unit Wheel
function Wheel(radius){
	this.radius = radius;
}

Wheel.prototype.acceleration = function(){
	return parseInt(2 * Math.PI * this.radius);	
}

// propulsion unit Propelling nozzle
var afterBurnerState = { 'On' : 1, 'Off': 0 };

function PropellingNozzle(power, afterBurnerState){
	this.power = power;
	this.afterBurnerState = afterBurnerState;	
}

PropellingNozzle.prototype.acceleration = function() {
	if(this.afterBurnerState === afterBurnerState.On){
		return this.power * 2;
	}

	return this.power;
}

// propulsion unit Propeller
var propellerSpinDirection = { 'Clockwise': 1, 'CounterClockwise': 2 };

function Propeller(numOfFins, spinDirection){
	this.numberOfFins = numOfFins;
	this.direction = spinDirection;
}

Propeller.prototype.acceleration =  function(){
	if(this.direction === propellerSpinDirection.Clockwise){
		return this.numberOfFins;
	}
	else if(this.direction === propellerSpinDirection.CounterClockwise){
		return -this.numberOfFins;
	}
}
// vehicle constructor
function Vehicle(speed, propulsionUnits){
	this.speed = speed;
	this.propulsionUnits = propulsionUnits;
	if(arguments.length > 2){
		this.extraUnits = arguments[2];
	}
}

Vehicle.prototype.Speed = function(){
	return this.speed;
}

Vehicle.prototype.AccelerateAndReturnSpeed = function(){
	return this.speed + this.Accelerate();
}

Vehicle.prototype.Accelerate = function(){
	var acceleration = 0;
	if(this.propulsionUnits instanceof Array){
		for (var i = 0; i < this.propulsionUnits.length; i++) {
			acceleration += this.propulsionUnits[i].acceleration();
		};
	}
	else{

		acceleration = this.propulsionUnits.acceleration();
	}
	return acceleration;
}

// land vehicle 
function LandVehicle(speed, wheels){
	Vehicle.apply(this,arguments);
}

LandVehicle.inherit(Vehicle);

// air vehicle
function AirVehicle(speed, propellingNozzle){
	Vehicle.apply(this,arguments);
}

AirVehicle.inherit(Vehicle);

AirVehicle.prototype.turnAfterBurnerOn = function(){
	this.propulsionUnits.afterBurnerState = afterBurnerState.On;
}

AirVehicle.prototype.turnAfterBurnerOff = function(){
	this.propulsionUnits.afterBurnerState = afterBurnerState.Off;
}

// water vehicle
function WaterVehicle(speed, propellers){
	Vehicle.apply(this,arguments);
}

WaterVehicle.inherit(Vehicle);

WaterVehicle.prototype.turnPropellerClockwise =  function(){
	for (var i = 1; i < this.propulsionUnits.length; i++) {
		this.propulsionUnits[i].direction = propellerSpinDirection.Clockwise;
	};
}

WaterVehicle.prototype.turnPropellerCounterClockwise =  function(){
	for (var i = 1; i < this.propulsionUnits.length; i++) {
		this.propulsionUnits[i].direction = propellerSpinDirection.CounterClockwise;
	};
}


var lander = new LandVehicle(30, [new Wheel(10), new Wheel(10),new Wheel(10),new Wheel(10)]);
console.log(lander.speed);
console.log(lander.AccelerateAndReturnSpeed());

var airer = new AirVehicle(100, new PropellingNozzle(350, afterBurnerState.Off));
console.log(airer.speed);
airer.turnAfterBurnerOn();
console.log(airer.AccelerateAndReturnSpeed());
airer.turnAfterBurnerOff();
console.log(airer.speed);

var waterer = new WaterVehicle(80, [new Propeller(5, propellerSpinDirection.Clockwise),
									new Propeller(5, propellerSpinDirection.Clockwise),
									new Propeller(5, propellerSpinDirection.Clockwise),
									new Propeller(5, propellerSpinDirection.Clockwise)])
console.log(waterer.speed);
console.log(waterer.AccelerateAndReturnSpeed());

var ampVehicleMode = {'Land': 1, 'Water': 2};
function AmphibiousVehicle(speed, wheels, propellers, initialMode){
	Vehicle.apply(this, arguments);
}

AmphibiousVehicle.inherit(Vehicle);

var amp = new AmphibiousVehicle(80, [new Wheel(10)], [new Propeller(5, propellerSpinDirection.Clockwise)], ampVehicleMode.and);
// TODO AmphibiousVehicle

opa.go;
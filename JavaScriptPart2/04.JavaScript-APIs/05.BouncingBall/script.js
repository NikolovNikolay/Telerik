(function(){
	var ctx = document.getElementById('the-can').getContext('2d');
	var _CANVAS_WIDTH = document.getElementById('the-can').offsetWidth;
	var _CANVAS_HEIGHT = document.getElementById('the-can').offsetHeight;

	var initialPosiion = (function(){
		var xPos, yPos;

		xPos = Math.floor(Math.random() * (((_CANVAS_WIDTH - 10) - 10) + 10) + 3);
		yPos = Math.floor(Math.random() * (((_CANVAS_HEIGHT - 10) - 10) + 10) + 3);
		
		return {
			x: xPos,
			y: yPos
		}

	})();

	
	function drawBall(x,y){
		ctx.beginPath();
		ctx.arc(x, y, 10, 0, Math.PI * 2);
		ctx.strokeStyle = 'blue';
		ctx.fillStyle = 'blue';
		ctx.fill();
		ctx.stroke();
	}	

	(function move(){
		var xPos = initialPosiion.x;
		var yPos = initialPosiion.y;
		var movementString = "down/right";
		var lastMovement = "";
		
		setInterval(function() {			
			ctx.clearRect(0,0,_CANVAS_WIDTH, _CANVAS_HEIGHT); // <-- comment this line if you want to track ball s path
			drawBall(xPos, yPos);
				switch(movementString){
					case "down/right": xPos++; yPos++; break;
					case "up/right": xPos++; yPos--; break;
					case "up/left": xPos--; yPos--; break;
					case "down/left": xPos--; yPos++; break;
				}

				if(yPos == _CANVAS_HEIGHT - 10 - 3){
					lastMovement = movementString;
					if(lastMovement == "down/right"){
						movementString = "up/right";
					} 
					else if(lastMovement == "down/left"){
						movementString = "up/left";
					}
				}
				else if(xPos == _CANVAS_WIDTH - 10 - 3){
					lastMovement = movementString;
					if(lastMovement == "up/right"){
						movementString = "up/left";
					}
					else if(lastMovement == "down/right"){
						movementString = "down/left";
					}					
				}
				else if(yPos == 0 + 10){
					lastMovement = movementString;
					if(lastMovement == "up/left"){
						movementString = "down/left";
					}
					else if(lastMovement == "up/right"){
						movementString = "down/right";
					}					
				}
				else if(xPos == 0 + 10){
					lastMovement = movementString;
					if(lastMovement == "down/left"){
						movementString = "down/right";						
					}
					else if(lastMovement == "up/left"){
						movementString = "up/right";
					}
				}
			} , 1);				
		})();
})();
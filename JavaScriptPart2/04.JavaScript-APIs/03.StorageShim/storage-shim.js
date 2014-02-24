if(typeof window.localStorage == 'undefined' || typeof window.sessionStorage == 'undefined'){
	(function(){
		var storage = function(type){

			function createCookie(name,value,expiration){
				var date, expires;
				if(expiration){
					date = new Date();
					date.setTime(date.getTime() + (expiration*24*3600*1000));
					expires = "; expires=" + date.toUTCString();
				} else{
					expires = "";
				}

				document.cookie = name + "=" + value + expires + "; path=/";
			}

			function readCookie(name) {
				var allCookies = document.cookie.split(";");
				for (var i = 0; i < allCookies.length; i++) {
			   		var cookie = allCookies[i];
			    	var trailingZeros = 0;
			    		for (var j = 0; j < cookie.length; j++) {
			      			if (cookie[j] !== " ") {
			        		break;
			      			}
			    		}
			    	cookie = cookie.substring(j);
			    	if (cookie.startsWith(name + "=")) {
			      		return cookie;
			    	}
			  	}
			}

		}
	})();
}
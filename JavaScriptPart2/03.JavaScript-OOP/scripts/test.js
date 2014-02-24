var opa = function(){
	
	function go(){
		var p = document.createElement('div');
		p.style.background = 'red';
		p.style.width = '100px';
		p.style.height = '100px';
		document.body.appendChild(p);
	}

	return{
		go: go
	}
}();
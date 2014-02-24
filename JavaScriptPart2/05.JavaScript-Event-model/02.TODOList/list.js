function resFields(){
			document.getElementById('title').value = "";
			document.getElementById('description').value = "";
}

var saveBtn = document.getElementById('save-btn');
saveBtn.addEventListener('click', function(){
	handleTask();
});

function handleTask(){
			var titleValue = (document.getElementById('title').value).trim();
			var descValue = (document.getElementById('description').value).trim();

			if(titleValue == "" || descValue == ""){
				return false;
			}

			var line = document.createElement('hr');
			var titleParagraph = document.createElement('p');
			titleParagraph.innerHTML = titleValue;
			titleParagraph.style.fontWeight = 'bold';
			var descParagraph = document.createElement('p');
			descParagraph.innerHTML = descValue;
			descParagraph.style.display = 'block';
			var containerDiv = document.createElement('div');
			var removeBtn = document.createElement('button');
			var toggleBtn = document.createElement('button');
			removeBtn.innerHTML = "remove";
			toggleBtn.innerHTML = "show/hide";
			containerDiv.style.padding = '0';
			containerDiv.style.width = '600px';
			containerDiv.style.margin = '5px';
			containerDiv.appendChild(titleParagraph);
			containerDiv.appendChild(descParagraph);
			containerDiv.appendChild(removeBtn);
			containerDiv.appendChild(toggleBtn);
			containerDiv.appendChild(line);
			removeBtn.addEventListener('click', function(){
				document.getElementById('tasks').removeChild(removeBtn.parentNode);
			});

			toggleBtn.addEventListener('click', function(){
				var prop = descParagraph.style.display;
				if(prop == 'block'){
					descParagraph.style.display = 'none';
				}
				else{
					descParagraph.style.display = 'block';
				}
			});
			document.getElementById('tasks').appendChild(containerDiv);
			resFields();
}
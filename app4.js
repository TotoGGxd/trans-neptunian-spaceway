function myFunction() {

    var input, filter, ul, li, a, i, txtValue;
    input = document.getElementById('myInput');
    filter = input.value.toUpperCase();
    ul = document.getElementById("myUL");
    li = ul.getElementsByTagName('li');
   
  
    for (i = 0; i < li.length; i++) {
      a = li[i].getElementsByTagName("a")[0];
      txtValue = a.textContent || a.innerText;
      if (txtValue.toUpperCase().indexOf(filter) > -1) {
        li[i].style.display = "";
       
      } else {
        li[i].style.display = "none";
      }
    }
  }



document.addEventListener("click", (evt) => {
    const flyoutElement = document.getElementById("myInput");
    let targetElement = evt.target; 
    do {
        if (targetElement == flyoutElement) {
            document.getElementById("myUL").style.display = "block";
            return;
        }
        targetElement = targetElement.parentNode;
    } while (targetElement);

    document.getElementById("myUL").style.display = "none";
});

// API

const planetDescription = document.getElementById('description');
const planetName = document.getElementById('name');
const square1 = document.getElementById('info');
const square2 = document.getElementById('info2');
const url = 'https://localhost:5001/api/planetas';

let getInfoPlanet = async () =>{
  const response = await fetch(url)
  const data = await response.json();
  planetName.innerText = data[3].nombre;
  planetDescription.innerText = data[3].description;
  square1.innerHTML = `${data[3].tiempo}`;
  square1.innerHTML += `${data[3].tamaño} ${data[3].temperatura}`;
  square2.innerHTML = `${data[3].distancia}`;
  console.log(data);
}
getInfoPlanet();
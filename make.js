const planetDescription = document.getElementById('description');
const planetName = document.getElementById('name');
const square1 = document.getElementById('info');
const square2 = document.getElementById('info2');
const url = 'https://localhost:5001/api/planetas';

let getInfoPlanet = async () =>{
  const response = await fetch(url)
  const data = await response.json();
  planetName.innerText = data[2].nombre;
  planetDescription.innerText = data[2].description;
  planetDescription.innerHTML += `<br>El tamaño del planeta es de ${data[2].tamaño} con una temperatura de ${data[2].temperatura}`;
  square1.innerHTML = `El tiempo en el que se desplaza es de ${data[2].tiempo}`;
  square2.innerHTML = `La distancia que hay entre el sol y ${data[2].nombre} es de ${data[2].distancia}`;
  console.log(data);
}
getInfoPlanet();
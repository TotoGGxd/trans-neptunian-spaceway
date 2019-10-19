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

/*if(document.getElementById("myInput").onclick){
    document.getElementById("myUL").style.display = "block";
}else{
    document.getElementById("myUL").style.display = "none";
}*/
/*
document.getElementById("myInput").onclick = function (){
    document.getElementById("myUL").style.display = "block";
}

document.onclick = function (){
    document.getElementById("myUL").style.display = "none";
}*/

/*document.onclick = function (){
    var windowClick=document.getElementById("myInput").click;
    if(windowClick){
        document.getElementById("myUL").style.display = "block";
    }
    else if(document.onclick){
        document.getElementById("myUL").style.display = "none";
    }
    
}
*/

if(document.getElementById()=="myInput"){

}
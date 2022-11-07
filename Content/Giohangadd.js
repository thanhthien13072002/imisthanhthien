
const btn = document.querySelectorAll("button")


console.log(btn)
btn.forEach(function ( button, index) {
    button.addEventListener("click", function (event) {
        var btniVen = event.target
        var product = btniVen.parentElement
        var img = product.querySelectorAll("class-img").src
        var Name = product.querySelectorAll("class-name").innerText
        var id = product.querySelectorAll("idsp").innerText
        var Gia = product.querySelectorAll("class-gia").innerText
        addcart(id,img,Name,Gia)
        console.log(id,img,Name,Gia)
       
    })
});
function addcart(id,img, Name, Gia){
    var add = document.createElement("tr")
    var trcon = '<tr><td>'+id+'</td><td><img src="'+ img+'" alt="Alternate Text" /></td>'+Name+'<td></td><td>'+Gia+'</td></tr>'
    add.innerHTML = trcon
    var cartbody = document.querySelectorAll("tb-sp")
    cartbody.append(add)
}


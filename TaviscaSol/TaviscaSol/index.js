function openCar(evt, Productname) {
    GetData(Productname);
}

function openHotel(evt, ProductName) {
    GetData(ProductName);
}

function openFlight(evt, ProductName) {
    GetData(ProductName);
}
function openActivity(evt, ProductName) {
    GetData(ProductName);
}

function GetData(bookingName)
{
   
    document.getElementById('tab-list').innerHTML ="";
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function ()
    {
        if (this.readyState === 4 && this.status === 200)
        {
            var myArr = JSON.parse(this.responseText);
            for (var i = 0; i < myArr.length; i++) {
                
                var iDiv = document.createElement('div');
                iDiv.id = i;
                iDiv.className ='List';
                document.getElementById('tab-list').appendChild(iDiv);
                var newElement = document.createElement("p");
                var node = document.createTextNode("ID: " + myArr[i].ProductID);
                newElement.appendChild(node);
                iDiv.appendChild(newElement);
                newElement = document.createElement("p");
                node = document.createTextNode("Name: " + myArr[i].Name);
                newElement.appendChild(node);
                iDiv.appendChild(newElement);
                newElement = document.createElement("p");
                node = document.createTextNode("Price: " + myArr[i].Price);
                newElement.appendChild(node);
                iDiv.appendChild(newElement);
                newElement = document.createElement("p");
                node = document.createTextNode("Saved: " + myArr[i].isSaved);
                newElement.appendChild(node);
                iDiv.appendChild(newElement);
                newElement = document.createElement("p");
                node = document.createTextNode("Booked: " + myArr[i].isBooked);
                newElement.appendChild(node);
                iDiv.appendChild(newElement);
                var x = document.createElement("HR");
                iDiv.appendChild(x);

            }
        }
    };
    xmlhttp.open("GET", "http://localhost:50074/api/" + bookingName, true);
    xmlhttp.send();

}


function PostMethod(bookingName) {
    var airInp = "airInp";
    var carInp = "carInp";
    var activityInp = "activityInp";
    var hotelInp = "hotelInp";
    if (bookingName === "Air")
    {
        json = {
            "ProductID": document.getElementsByClassName(airInp)[0].value,
            "Name": document.getElementsByClassName(airInp)[1].value,
            "Price": document.getElementsByClassName(airInp)[2].value,
            "isSaved": "0",
            "isBooked": "0"
        };
    }
    else if (bookingName === "Car")
    {
       
        json = {
            "ProductID": document.getElementsByClassName(carInp)[0].value,
            "Name": document.getElementsByClassName(carInp)[1].value,
            "Price": document.getElementsByClassName(carInp)[2].value,
            "isSaved": "0",
            "isBooked": "0"
        };
    }
    else if (bookingName === "Activity")
    {
        json = {
            "ProductID": document.getElementsByClassName(activityInp)[0].value,
            "Name": document.getElementsByClassName(activityInp)[1].value,
            "Price": document.getElementsByClassName(activityInp)[2].value,
            "isSaved": "0",
            "isBooked": "0"
        };
    }
    else
    {
        json = {
            "ProductID": document.getElementsByClassName(hotelInp)[0].value,
            "Name": document.getElementsByClassName(hotelInp)[1].value,
            "Price": document.getElementsByClassName(hotelInp)[2].value,
            "isSaved": "0",
            "isBooked": "0"
        };
    }
    json = JSON.stringify(json);
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            console.log(this.responseText);
        }
    };
    xmlhttp.open("POST", "http://localhost:50074/api/" + bookingName, true);

    xmlhttp.setRequestHeader("Content-Type", "application/json; charset=utf-8");
    xmlhttp.send(json);
}

function GetList(ProductType) {
    var request = new XMLHttpRequest();
    request.open("GET", "http://localhost:50074/api/" + ProductType, true);
    request.onload = function () {
        var data = JSON.parse(this.response);
        if (request.status >= 200 && request.status < 400) {
            displaylist.innerHTML = "";
            var table = document.createElement("table");
            var row = document.createElement("tr");
            var col = document.createElement("th");
            var node = document.createTextNode("Id");
            col.appendChild(node);
            row.appendChild(col);
             col = document.createElement("th");
            node = document.createTextNode("Name");
            col.appendChild(node);
            row.appendChild(col);
             col = document.createElement("th");
            node = document.createTextNode("IsSaved");
            col.appendChild(node);
            row.appendChild(col);
             col = document.createElement("th");
            node = document.createTextNode("IsBooked");
            col.appendChild(node);
            row.appendChild(col);
             col = document.createElement("th");
            node = document.createTextNode("Price");
            col.appendChild(node);
            row.appendChild(col);
             col = document.createElement("th");
            node = document.createTextNode("Book or Save");
            col.appendChild(node);
            row.appendChild(col);
            table.appendChild(row);
            var list = document.getElementById("displaylist");
            list.appendChild(table);
            for (let i = 0; i < data.length; i++) {
                 row = document.createElement("tr");
                 col = document.createElement("td");
                node = document.createTextNode(data[i].ID);
                col.appendChild(node);
                row.appendChild(col);
                col = document.createElement("td");
                node = document.createTextNode(data[i].Name);
                col.appendChild(node);
                row.appendChild(col);
                 col = document.createElement("td");
                node = document.createTextNode(data[i].IsSaved);
                col.appendChild(node);
                row.appendChild(col);
                 col = document.createElement("td");
                node = document.createTextNode(data[i].IsBooked);
                col.appendChild(node);
                row.appendChild(col);
                 col = document.createElement("td");
                node = document.createTextNode(data[i].Price);
                col.appendChild(node);
                row.appendChild(col);
                 col = document.createElement("button");
                var b = 'book' + [i + 1];
                col.setAttribute("id", b);
                node = document.createTextNode("Book");
                col.appendChild(node);
                row.appendChild(col);
                 col = document.createElement("button");
                var s = 'save' + [i + 1];
                col.setAttribute("id", s);
                node = document.createTextNode("Save");
                col.appendChild(node);
                row.appendChild(col);
                table.appendChild(row);
                list.appendChild(table);
                document.getElementById(b).addEventListener("click", function () {
                    book(data[i].ID, ProductType);
                });
                document.getElementById(s).addEventListener("click", function () {
                    save(data[i].ID, ProductType);
                });
            }
        }
    };
    request.send();
}

function book(id, type) {
    json = {
        "id": id,
        "activity": "Book"
    };
    json = JSON.stringify(json);
    var server = new XMLHttpRequest();
    server.open("PUT", "http://localhost:50074/api/" + type, true);
    server.onload = function () {
        GetList("Car");
    };
    server.setRequestHeader("Content-Type", "application/json; charset=utf-8");
    server.send(json);
}

function save(id, type) {
    json = {
        "id": id,
        "activity": "Save"
    };
    json = JSON.stringify(json);
    var server = new XMLHttpRequest();
    server.open("PUT", "http://localhost:50074/api/" + type, true);
    server.onload = function () {
        GetList("Car");
    };
    server.setRequestHeader("Content-Type", "application/json; charset=utf-8");
    server.send(json);
}



obtenerPersonas()
function obtenerPersonas() {
    //  fectch /controladorNombre/functionnombre
    fetch('/Usuarios/obtenerPersonas')
        .then(function (respuesta) {
            if (respuesta.ok) {
                return respuesta.json();
            }
        })
        .then(function (data) {
            let tbody = document.querySelector("#myTable tbody")
            tbody.innerHTML = '';
            console.log(data)
            data.forEach(function (datosT) {
                let fila = document.createElement("tr");
                fila.innerHTML = `
                    <td>${datosT.cui}</td>
                    <td>${datosT.nombre}</td>
                    <td>${datosT.apellido}</td>
                    <td>${datosT.mail}</td>
                    <td>${datosT.telefono}</td>
                    <td>${datosT.estado}</td>
                    <td>${convertirFechaJSON(datosT.fechaRegistro)}</td>
                    <td>
                   <button type="button" class="btn btn-primary" onclick="obtenerPersona(${datosT.cui})">editar</button>
                   </td>
                `;
                tbody.appendChild(fila);

        
            });
            
        });
}



function insertarPersona() {
    const dataF = new FormData(document.getElementById("formulario"));
    fetch('/Usuarios/insertarPersona', {
        method: "POST",
        body: dataF
    })
        .then(function (respuesta) {
            if (respuesta.ok) {
                return respuesta.json();
            }
        })
        .then(function (data) {
            if (data === 1) {
                console.log("insert realizado");
                obtenerPersonas()

            } else {
                console.log("insert Fallido");
            }
        })
        .catch(function (error) {
            console.error("Error:", error);
        });
}




function obtenerPersona(cui) {
    let cui1 = document.getElementById("cui")
    let nombre = document.getElementById("nombre")
    let apellido = document.getElementById("apellido")
    let mail = document.getElementById("mail")
    let telefono = document.getElementById("telefono")
    let estado = document.getElementById("estado")
    let fechaRegistro = document.getElementById("fechaRegistro")

    console.log("presionado"+cui)

    fetch('/Usuarios/obtenerPersona?cui='+ cui)
        .then(function (respuesta) {
            if (respuesta.ok) {
                return respuesta.json();
            }
        })
        .then(function (data) {
            cui1.value = data.cui
            nombre.value = data.nombre
            apellido.value = data.apellido
            mail.value = data.mail
            telefono.value = data.telefono
            estado.value = data.estado
            fechaRegistro.value = convertirFechaJSON(data.fechaRegistro)
            console.log(fechaRegistro.value)
           

        })
}


//este si funciona para corregir fecha
function convertirFechaJSON(jsonFecha) {
    var timestamp = parseInt(jsonFecha.match(/\d+/)[0]);
    var fecha1 = new Date(timestamp);
    var fecha = new Date(fecha1);
    var dia = fecha.getDate().toString().padStart(2, '0');
    var mes = (fecha.getMonth() + 1).toString().padStart(2, '0');
    var año = fecha.getFullYear();
    var fechaFormateada = `${año}-${mes}-${dia}`;
    return fechaFormateada;
}
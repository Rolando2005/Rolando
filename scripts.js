let dailyRecords = [];
let accumulatedRecords = [];

document.getElementById("dailyRecordForm").addEventListener("submit", function(event) {
    event.preventDefault();
    let date = document.getElementById("date").value;
    let description = document.getElementById("description").value;
    let amount = parseFloat(document.getElementById("amount").value);
    dailyRecords.push({date, description, amount});
    loadDailyRecords();
    updateAccumulatedRecords(date, amount);

    fetch('http://localhost:3000/addDailyRecord', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ fecha: date, descripcion: description, cantidad: amount })
    })
    .then(response => response.text())
    .then(data => {
        console.log(data);
    })
    .catch(error => {
        console.error('Error:', error);
    });
});

function loadDailyRecords() {
    let table = document.getElementById("dailyRecords");
    table.innerHTML = "<tr><th>Fecha</th><th>Descripción</th><th>Cantidad</th></tr>";
    dailyRecords.forEach(record => {
        let row = table.insertRow();
        row.insertCell(0).innerText = record.date;
        row.insertCell(1).innerText = record.description;
        row.insertCell(2).innerText = record.amount;
    });
}

function updateAccumulatedRecords(date, amount) {
    let month = new Date(date).toLocaleString('es-ES', { month: 'long' });
    let record = accumulatedRecords.find(record => record.month === month);
    if (record) {
        record.totalAmount += amount;
    } else {
        accumulatedRecords.push({month, totalAmount: amount});
    }
    loadAccumulatedRecords();
}

function loadAccumulatedRecords() {
    let table = document.getElementById("accumulatedRecords");
    table.innerHTML = "<tr><th>Mes</th><th>Cantidad Total</th></tr>";
    accumulatedRecords.forEach(record => {
        let row = table.insertRow();
        row.insertCell(0).innerText = record.month;
        row.insertCell(1).innerText = record.totalAmount;
    });
}

function generateDailyReport() {
    let output = document.getElementById("reportOutput");
    output.innerHTML = "<h3>Reporte Diario</h3><table><tr><th>Fecha</th><th>Descripción</th><th>Cantidad</th></tr>";
    dailyRecords.forEach(record => {
        let row = document.createElement("tr");
        row.insertCell(0).innerText = record.date;
        row.insertCell(1).innerText = record.description;
        row.insertCell(2).innerText = record.amount;
        output.querySelector("table").appendChild(row);
    });
    output.innerHTML += "</table>";
}

// Cargar datos al iniciar
window.onload = function() {
    // Implementar la función de cargar registros diarios desde el servidor aquí si es necesario
    loadDailyRecords();
};

function getAllPersons() {
    $.get("/Ajax/GetAllPersons", null, function (data) {
        $("#PersonList").html(data);
    });
}

function getPersonByID() {
    var personIDValue = document.getElementById('PersonIdInput').value;
    $.post("/Ajax/FindPersonById", { personID: personIDValue }, function (data) {
        $("#PersonList").html(data);
    });
}

function deletePersonByID() {
    var personIDValue = document.getElementById('PersonIdInput').value;
    $.post("/Ajax/DeletePersonById", { personID: personIDValue }, function (data) {

    })
        .done(function () {
            getAllPersons();
            document.getElementById('errorMessages').innerHTML = "Successfully Deleted person.";
        })
        .fail(function () {
            document.getElementById('errorMessages').innerHTML = "Could not delete person.";
        });

}
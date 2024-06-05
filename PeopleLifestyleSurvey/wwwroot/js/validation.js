function validateForm() {
    let fullName = document.getElementById("FullName").value;
    let email = document.getElementById("Email").value;
    let dateOfBirth = document.getElementById("DateOfBirth").value;
    let contactNumber = document.getElementById("ContactNumber").value;
    let ratings = document.querySelectorAll('input[type="radio"]:checked').length;

    if (!fullName || !email || !dateOfBirth || !contactNumber) {
        alert("All personal details must be filled out.");
        return false;
    }

    let dob = new Date(dateOfBirth);
    let age = new Date().getFullYear() - dob.getFullYear();
    if (age < 5 || age > 120) {
        alert("Age must be between 5 and 120.");
        return false;
    }

    if (ratings < 4) {
        alert("You must rate all the preferences.");
        return false;
    }

    return true;
}

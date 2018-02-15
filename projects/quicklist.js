  //Renames Tags For Easier Coding
$(document).ready(function () {
      var $newItemButton = $('#newItemButton');
      var $newItemForm = $('#newItemForm');
      var $textInput = $('input:text');

      $newItemButton.show(); //Temporarily Hides Features
      $newItemForm.hide();
      
      $('#showForm').on('tap click', function(){
        $newItemButton.hide();
        $newItemForm.show();
      });
      
      //THIS SECTION CONTROLS DELETE FUNCTION ON LISTS
        $('li.list').on('doubletap dblclick', function(){
        $(this)
        .fadeOut(1000); //Starts Animation
        setTimeout(function(){//Delay Activates
        $(this).remove();}, 1000);//Delays Removal Of Item
      }); //Both Do Same Thing.Consistant Support Below
        $(document.body).on('doubletap dblclick', '.list', function(){
        $(this)
        .fadeOut(1000); //Starts Animation
        setTimeout(function(){//Delay Activates
        $(this).remove();}, 1000);//Delays Removal Of Item
      });
      
      //Loads In Form
        $newItemForm.on('submit', function(e){
        e.preventDefault();
        var newText = $textInput.val();//Takes Textbox Value
        $('.list:last').after('<li class="list">' + newText + '</li>');//Puts TextBox Value Into List
        $newItemForm.hide();//Hides Text Box
        $newItemButton.show();//Shows New Item Button
        $textInput.val('');//Empties Text Box
      });
      
      //Cancels The Form
        $('#cancelButton').on('tap click', function(e){
        e.preventDefault();
        $newItemForm.hide();//Hides Text Box
        $newItemButton.show();//Shows New Item Button
        $textInput.val('');//Empties Text Box
        });
      
});


//Gives An Error Message If Nothing Is Entered
function noInput() {
    var EMPTY;
    EMPTY = document.getElementById("itemNameInput").value;
    if (EMPTY === "") {
        alert("You Must Enter Something");
        return false;
    }
}

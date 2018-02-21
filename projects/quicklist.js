  //Renames jQuery Tags For Easier Coding
$(document).ready(function () {
      var $newItemButton = $('#newItemButton');
      var $newItemForm = $('#newItemForm');
      var $textInput = $('input:text');
      var $formBackground = $('#formBackground');
      
      //Text Editing Buttons "Bold, Underline, Normal, Cancel"
      var $cancelButton = $('#cancelButton');
      var $boldButton = $('#boldButton');
      var $underlineButton = $('#underlineButton');
      var $italicButton = $('#italicButton');
      
      $newItemButton.show(); //Temporarily Hides Features
      $newItemForm.hide();
      $formBackground.hide();
      $cancelButton.hide();
      $boldButton.hide();
      $underlineButton.hide();
      $italicButton.hide();
      $cancelButton.prop('disabled', true);
      
      $('#showForm').on('tap click', function(e){
        $newItemButton.hide();
        $newItemForm.show();
        $formBackground.show();
        $cancelButton.show();
        $boldButton.show();
        $underlineButton.show();
        $italicButton.show();
       $cancelButton.prop('disabled', false);
});

//Buttons__________________________________________________________________
      $('#boldButton').on('tap click', function(e){
        e.preventDefault();
        var newText = $textInput.val();//Takes Textbox Value
        $('.list:last').after('<li class="list"><b>' + newText + '</b></li>');//Puts TextBox Value Into List
        $newItemForm.hide();//Hides Text Box
        $formBackground.hide();
        $newItemButton.show();//Shows New Item Button
        $cancelButton.hide();
        $boldButton.hide();
        $underlineButton.hide();
        $italicButton.hide();
        $textInput.val('');//Empties Text Box
});
      $('#underlineButton').on('tap click', function(e){
        e.preventDefault();
        var newText = $textInput.val();//Takes Textbox Value
        $('.list:last').after('<li class="list"><u>' + newText + '</u></li>');//Puts TextBox Value Into List
        $newItemForm.hide();//Hides Text Box
        $formBackground.hide();
        $newItemButton.show();//Shows New Item Button
        $cancelButton.hide();
        $boldButton.hide();
        $underlineButton.hide();
        $italicButton.hide();
        $textInput.val('');//Empties Text Box
});
      
      //THIS SECTION CONTROLS DELETES ITEMS ON LIST
        $('li.list').on('doubletap dblclick', function(){
        $(this)
        .fadeOut(1000); //Starts Animation
        $(this).css({
	       "text-decoration": "line-through"
      });
        setTimeout(function(){//Delay Activates
        $(this).remove();}, 1000);//Delays Removal Of Item
      }); //Both Do Same Thing.Consistant Support Below
        $(document.body).on('doubletap dblclick', '.list', function(){
        $(this)
        .fadeOut(1000); //Starts Animation
        $(this).css({
	       "text-decoration": "line-through"
      });
        setTimeout(function(){//Delay Activates
        $(this).remove();}, 1000);//Delays Removal Of Item
      });
      
      //Loads In Form
        $newItemForm.on('submit', function(e){
        e.preventDefault();
        var newText = $textInput.val();//Takes Textbox Value
        $('.list:last').after('<li class="list">' + newText + '</li>');//Puts TextBox Value Into List
        $newItemForm.hide();//Hides Text Box
        $formBackground.hide();
        $newItemButton.show();//Shows New Item Button
        $cancelButton.hide();
        $boldButton.hide();
        $underlineButton.hide();
        $italicButton.hide();
        $textInput.val('');//Empties Text Box
      });
      
      //Cancels The Form
        $('#cancelButton').on('tap click', function(e){
        e.preventDefault();
        $newItemForm.hide();//Hides Text Box
        $formBackground.hide();
        $newItemButton.show();//Shows New Item Button
        $cancelButton.hide();
        $boldButton.hide();
        $underlineButton.hide();
        $italicButton.hide();
        $textInput.val('');//Empties Text Box
        });
      
});


//Gives An Error Message If Nothing Is Entered
function noInput() {
    var EMPTY;
    EMPTY = document.getElementById("itemNameInput").value;
    if (EMPTY === "") {
        return false;
    }
}

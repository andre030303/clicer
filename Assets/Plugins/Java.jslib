mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert(player.getName());
    myGameInstance.SendMessage('yabdex', 'nemenes', player.getName());
  },
  saveExtern: function (date) {
    var dateString = UTF8ToString(date);
    var myobj = JSON.parse(dateString);
    player.setData(myobj);
  },
  loadExtern: function () {
    player.getData().then(_date => {
      const myJSON = JSON.stringify(_date);
      myGameInstance.SendMessage('perenos', 'Load', myJSON);
    });
  },
});
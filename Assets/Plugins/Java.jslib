mergeInto(LibraryManager.library, {
  tabl: function (date) {
    ysdk.getLeaderboards()
    .then(lb => {
      var clicString = UTF8ToString(clic);
      console.log(clicString);
      lb.setLeaderboardScore('Klic', clicString);
      lb.getLeaderboardEntries('Klic')
      .then(res => console.log(res));
    });
  },

  advshow: function () {
    ysdk.adv.showFullscreenAdv({
      callbacks: {
        onClose: function(wasShown) {
          // some action after close
        },
        onError: function(error) {
          // some action on error
        }
      }
    })
  },

  rec: function () {
    ysdk.adv.showRewardedVideo({
      callbacks: {
        onOpen: () => {
          console.log('Video ad open.');
        },
        onRewarded: () => {
          console.log('Rewarded!');
          myGameInstance.SendMessage('yandex', 'addsmanu');
        },
        onClose: () => {
          console.log('Video ad closed.');
        }, 
        onError: (e) => {
          console.log('Error while open video ad:', e);
        }
      }
    })
  },
  getlang: function () {
    var lang = ysdk.environment.i18n.lang;
    var bufferSize = lengthBytesUTF8(lang) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(lang, buffer, bufferSize);
    return buffer;
  },
  ozen: function () {
    ysdk.feedback.canReview()
    .then(({ value, reason }) => {
      if (value) {
        ysdk.feedback.requestReview()
        .then(({ feedbackSent }) => {
          console.log(feedbackSent);
        })
      } else {
        console.log(reason)
      }
    })
  },
  saveExtern: function (date) {
    console.log(date);
    var dateString = UTF8ToString(date);
    console.log(dateString);
    var myobj = JSON.parse(dateString);
    console.log(myobj);
    player.setData(myobj);
  },
  loadExtern: function () {
    player.getData().then(_date => {
      const myJSON = JSON.stringify(_date);
      myGameInstance.SendMessage('perenos', 'Load', myJSON);
    });
  },
});
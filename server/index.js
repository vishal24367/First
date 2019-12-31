var app = require('express')();
var server = require('http').Server(app);
var io = require('socket.io')(server);

server.listen(3000);

app.get('/', function(socket) {
  socket.emit('message', {hello:'world'});
  socket.on('message',function(data) {
    console.log(data);

  });
});

console.log("------- server is running -------");
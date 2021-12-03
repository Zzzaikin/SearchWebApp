const express = require('express')
const history = require('connect-history-api-fallback')
const app = express()

app.use(history())
app.use(express.static(__dirname + '/dist'))
/* app.get('/', (req, res) => {
    console.log('aa')
    res.send('sss')
}) */
app.listen(80, function() {
    console.log('Сервер ожидает подключения')
})

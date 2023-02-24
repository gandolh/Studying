const express = require('express')
const app = express()
const port = 8084

app.get('/', (req, res) => {
  console.log('root fetched')
  res.send('Hello World!')
})

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})
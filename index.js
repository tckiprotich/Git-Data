const express = require('express');
const app = express();
const port = 3000;

// MIDDLEWARE
app.use(express.static('public'));
app.use(express.json());
app.use(express.urlencoded({ extended: true }));


// ROUTES
app.get('/', (req, res) => res.send('Hello World!'));
app.use('/api', require('./routes/api'));

// LISTEN
app.listen(port, () => console.log(`Example app listening on port ${port}!`));


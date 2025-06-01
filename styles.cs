
body {
  font-family: 'Roboto', sans-serif;
  margin: 0;
  padding: 0;
  color: #333;
}

header {
  background: #222;
  color: #fff;
  padding: 1em 0;
}

.container {
  width: 90%;
  max-width: 1200px;
  margin: 0 auto;
}

nav ul {
  list-style: none;
  padding: 0;
  display: flex;
  justify-content: center;
  gap: 1.5em;
}

nav a {
  color: #ffd700;
  text-decoration: none;
}

.hero {
  background: url('../imagens/oficina1.jpg') center/cover no-repeat;
  color: white;
  text-align: center;
  padding: 5em 1em;
}

.btn {
  display: inline-block;
  background: #ffcc00;
  color: #000;
  padding: 0.75em 1.5em;
  border-radius: 5px;
  text-decoration: none;
  margin-top: 1em;
}

.gray {
  background: #f7f7f7;
}

section {
  padding: 3em 1em;
}

.equipe img,
.galeria img {
  max-width: 30%;
  margin: 0.5em;
  border-radius: 10px;
}

.servicos-lista {
  display: flex;
  flex-wrap: wrap;
  gap: 1em;
  list-style: none;
  padding: 0;
}

.servicos-lista li {
  background: #eee;
  padding: 1em;
  border-radius: 8px;
  flex: 1 1 200px;
  text-align: center;
}

form {
  display: flex;
  flex-direction: column;
  gap: 1em;
}

form input,
form textarea {
  padding: 0.75em;
  border: 1px solid #ccc;
  border-radius: 5px;
}

form button {
  background: #ffcc00;
  color: #000;
  padding: 0.75em;
  border: none;
  border-radius: 5px;
  cursor: pointer;
}

footer {
  background: #222;
  color: #fff;
  text-align: center;
  padding: 1em 0;
  margin-top: 2em;
}

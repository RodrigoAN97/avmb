let heroesTable = [["Id", "Name", "Description", "Modified"]];

function fetchHeroes() {
  fetch(
    "https://gateway.marvel.com:443/v1/public/characters?apikey=2ea5197226ee89f9a91c24a4ffd823bd"
  )
    .then(function (response) {
      return response.json();
    })
    .then(function (data) {
      const heroes = data.data.results;
      for (let hero of heroes) {
        heroesTable.push([hero.id, hero.name, hero.description, hero.modified]);
      }

      let table = document.createElement("table");
      document.body.appendChild(table);

      heroesTable.forEach(function (row) {
        var tr = table.insertRow();

        row.forEach(function (column) {
          var td = tr.insertCell();
          td.innerText = column;
        });
      });
    });
}

fetchHeroes();

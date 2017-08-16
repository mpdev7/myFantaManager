var module = angular.module("myFantaApp");

module.controller("playersListController", [
    "$http",
    "$timeout",
    function ($http, $timeout) {
        var self = this;

        self.teamList = [
            { value: "", text: "Tutte" },
            { value: "Atalanta", text: "Atalanta" },
            { value: "Benevento", text: "Benevento" },
            { value: "Bologna", text: "Bologna" },
            { value: "Cagliari", text: "Cagliari" },
            { value: "Chievo", text: "Chievo" },
            { value: "Crotone", text: "Crotone" },
            { value: "Fiorentina", text: "Fiorentina" },
            { value: "Genoa", text: "Genoa" },
            { value: "Verona", text: "Verona" },
            { value: "Inter", text: "Inter" },
            { value: "Juventus", text: "Juventus" },
            { value: "Lazio", text: "Lazio" },
            { value: "Milan", text: "Milan" },
            { value: "Napoli", text: "Napoli" },
            { value: "Roma", text: "Roma" },
            { value: "Sampdoria", text: "Sampdoria" }, 
            { value: "Sassuolo", text: "Sassuolo" },
            { value: "Spal", text: "Spal" },
            { value: "Torino", text: "Torino" },
            { value: "Udinese", text: "Udinese" }
        ];

        self.ownersList = [
            { value: "", text: "Tutte" },
            { value: "Lupin", text: "Lupin" },
            { value: "Brentone", text: "Brentone" },
            { value: "Polisportiva", text: "Polisportiva" },
            { value: "Olimpia", text: "Olimpia" },
            { value: "Inazuma", text: "Inazuma" },
            { value: "Pippero", text: "Pippero" },
            { value: "L3", text: "L3" },
            { value: "ElMorelo", text: "ElMorelo" }
        ];

        self.roleColor = {
            P: "blue",
            D: "green",
            C: "yellow",
            A: "red"
        };

        self.Title = "Lista Giocatori";
        self.playerName = "";
        self.roleName = "";
        self.teamName = self.teamList[0].value;
        self.printEnabled = false;
        self.hiddenOwnersColumn = false;
        self.ownersName = self.ownersList[0].value;

        self.clickFilter = function () {
            $http.get("api/players/GetPlayerByName?playerName=" + self.playerName + "&roleName=" + self.roleName + "&teamName=" + self.teamName)
                .then(function (result) {
                    self.players = result.data;
                },
                function (error) {
                    console.log(error);
                });
        };


        self.print = function () {
            self.printEnabled = true;
            $timeout(function () {
                window.print();
                self.printEnabled = false;
            }, 1);
            //
            
        };

        self.init = function () {
            $http.get("api/players/GetAllPlayers")
                .then(function (result) {
                    self.players = result.data;
                },
                function (error) {
                    console.log(error);
                });
        };


    }
]);
let app = new angular.module('sikidegek', ['ngRoute']);

app.run(function($rootScope) {
    $rootScope.title = 'Sík és térbeli alakzatok';
    $rootScope.author = '2/14. szoftverfejlesztő Síkidegek';
    $rootScope.company = 'Bajai SZC Türr István Technikum';

    $rootScope.links = [{
            name: 'Bemutatkozás',
            url: '/home'
        },
        {
            name: 'Program',
            url: '/program'
        },
    ];
});

app.config(function($routeProvider) {
    $routeProvider
        .when('/home', {
            templateUrl: 'views/home.html',
            controller: 'homeCtrl'
        })
        .when('/program', {
            templateUrl: 'views/program.html',
            controller: 'programCtrl'
        })
        .otherwise('/home')
});
import tpl1 from '../views/DIALOG1TMPL.html'
import dialogCtr from '../controller/dialogController'
export default class pageDController {
    constructor ($interval,httpService,utils) {
        this.httpservice = httpService;
        this.ut = utils;
        this.activated = true;
    };
    submit () {
        console.log(this.query);
       fetch('http://localhost:52273/api/values').then(function(response) {
          return response.json();
        }).then(function(data) {
          console.log(data);
        }).catch(function(e) {
          console.log("Oops, error");
        });
    };
    //显示密码绑定事件
    toggleActivation () {

    };
}
pageDController.$inject = ['$interval','httpService','utils'];
// ==UserScript==
// @name         Worlds Dumbest Game
// @namespace    none
// @version      1.0
// @description  This Is The Most Easiest Game I've Ever Modded. A Version With Controllable Points Will Be Coming Soon!
// @author       @ITS_N1GH7OWL
// @match        https://www.worldsdumbestgame.com/*
// @match        http://www.worldsdumbestgame.com/*
// @require      https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js">
// @grant        none
// ==/UserScript==
$('span.counter').html('<span class="counter" data-direction="up" data-interval="100" data-format="59:59.9"><div id="points">59:59:9</div></span>');
$('h6').prepend('<div class="modCSS"><h2>Mod By <b><u><a href="https://teamnightowl.ca/">Teamnightowl</a></u></b></div><style>div.modCSS {font-family: "Arial Black", Gadget, sans-serif;}</style>');
$('#ad').remove();
$('.twit').remove();
$('.fb').remove();
$('.social').remove();


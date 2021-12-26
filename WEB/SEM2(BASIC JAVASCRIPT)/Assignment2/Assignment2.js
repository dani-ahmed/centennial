function table() {

    var rows = document.getElementById('rows').value;
    var columns = document.getElementById('columns').value;
    var top = '<h1>YOUR TABLE</h1>\n<table style="text-align:left" border = "1">\n';
    var body = '';


    for (var i = 1; i <= rows; i++) {
        body +='<tr style="padding:10px">';
        for (var j = 1; j <= columns; j++) {
            body += '<td style="padding:10px">';
            body += i + ', ' + j;
            body += '</td>';
          
        }
        body += '</tr>\n';
    }
    body += '</table>';
    document.getElementById('table').innerHTML = top + body;
}
document.getElementById('submit').addEventListener('click', table, false);
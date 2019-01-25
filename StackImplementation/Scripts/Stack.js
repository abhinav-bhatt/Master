//<script src="~/Scripts/jquery-3.3.1.min.js"></script>
//<script type="text/javascript">
$(document).ready(function () {
    var tableElem = $("<table class='table table-bordered' id='tbll'></table>");
    var tbodyElem = $("<tbody id='bdyid'></tbody>");
    var tdElem;
    var trElem;
    $('#btnstackCreate').click(function () {
        var cap = $('#stackSize').val();
        $.ajax({
            url: '/Home/CreateStack'/*'@Url.Action('CreateStack', 'Home')'*/,
            data: { stackSize: cap },
            success: function (data) {
                console.log(data);
                if (data == 'Stack is already created') { alert('Stack is already created') }
                else {

                    $.each(data, (i, val) => {
                        tdElem = $("<td id='tdid" + i + "'" + " align='center'></td>").text(val);
                        trElem = $("<tr></tr>").html(tdElem);
                        tbodyElem.append(trElem);
                    });
                    tableElem.html(tbodyElem);
                    $('#stackView').append(tableElem);
                }
            },
            error: function (e) {
                console.log(e);
            }
        });
    });

    $('#btnPush').click(function () {
        var cap = $('#txtPush').val();
        $.ajax({
            url: '/Home/Push',
            data: { value: cap },
            success: function (data) {
                if (data == 'Stack is full') { alert('Stack is full') }
                else {
                    $.each(data, (i, val) => {
                        $('#tdid' + i).text(val);
                    });
                    console.log(data);
                } 
            },
            error: function (e) {
                console.log(e);
            }

        });
    });
    $('#btnPop').click(function () {
        $.ajax({
            url: '/Home/Pop',
            success: function (data) {
                if (data == 'Stack is empty') { alert('Stack is empty') }
                else {
                    $.each(data, (i, val) => {
                        $('#tdid' + i).text(val);
                    });
                    console.log(data);
                }
            },
            error: function (e) {
                console.log(e);
            }
            });
            
        });
    $('#btnDelete').click(function () {
        $.ajax({
            url: '/Home/Delete',
            success: $('#bdyid').empty()
        });
    });

});
//</script>  
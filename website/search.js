$(function(){
    
    $('.who').bind("change keyup input click", function() {
        console.log(this.value);
        if(this.value.length >= 2){
            $.ajax({
                type: 'POST',
                url: "stock.php", 
                //dаta: {referal: this.value},
                data: "referal="+this.value,
                response: 'text',
                success: function(data){
                    $(".search_result").html(data).fadeIn(); 
                }
            })
        }
    })
        
    $(".search_result").hover(function(){
        $(".who").blur(); 
    })
        
    
    $(".search_result").on("click", "li", function(){
        s_user = $(this).text();
        $(".search_result").fadeOut();
    })
})
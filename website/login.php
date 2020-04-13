<!DOCTYPE html>
<html>
<body>
<img class="loginLogo" src="logo.jpeg">
    <div class="container">
  
        <div class="img">
        </div>
        <div class="login-content">
             
            <form >
            
                <h2 class="title">Welcome</h2>
                <div class="input-div one">
                    <div class="i">
                    </div>
                    <div class="div">
                        <h5>Username</h5>
                        <input type="text" class="input">
                    </div>
                </div>
                <div class="input-div pass">
                    <div class="i">
                    </div>
                    <div class="div">
                        <h5>Password</h5>
                        <input type="password" class="input">
                    </div>
                </div>
               
                <input type="submit" class="btn" value="Login">
            </form>
        </div>
    </div>
</body>
</html>



<script>
const inputs = document.querySelectorAll(".input");


function addcl(){
	let parent = this.parentNode.parentNode;
	parent.classList.add("focus");
}

function remcl(){
	let parent = this.parentNode.parentNode;
	if(this.value == ""){
		parent.classList.remove("focus");
	}
}


inputs.forEach(input => {
	input.addEventListener("focus", addcl);
	input.addEventListener("blur", remcl);
});
</script>


<?php
include_once "../apiv2/pdo.php";
include_once "../apiv2/PERSONNE/read/functions.php";
include_once "../apiv2/ROLE/read/functions.php";

// Vérification du login
if (isset($_POST['username']) && isset($_POST['password'])) {
    $password = $_POST['password'];
    $username = $_POST['username'];

    $hashed_pass = hash("sha256", $password.$username);

    $password = hash("sha256", $hashed_pass);
    $email = $username;

    $id = GetUserIdByEmail($email);

    if ($id['id'] != null) {

      $idHash = hash("sha256", $id['id']);
      $pass = hash("sha512", $idHash.$password);

      $login = Login($email, $pass);

      if ($login != null) {
          // LE LOGIN EST OK
          $logged_user = GetUserById($id['id']);
          $_SESSION['user'] = $logged_user;

          header('Location: https://waview.ch/wavcontact/map');
      }
      else {
          // Login pas OK
      }
    }
  }
?>

<!DOCTYPE html>
<html lang="en">
  <head>
   <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
  </head>

  <body>
    <div class="container">
      <div class="row">
        <div class="col-sm-12" align="center">
          <img src="../../images/waview.png" alt="" style="width:10%">
          <h1>WaveMap</h1>
        </div>
      </div>

      <hr>

      <div class="row">
        <div class="col-sm-12 d-flex justify-content-center">
          <div class="wrapper">
              <h2>Sign In</h2>
              <form action="" method="post">
                  <div class="form-group">
                      <label>Email</label>
                      <input type="text" name="username" class="form-control <?php echo (!empty($username_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $username; ?>">
                      <span class="invalid-feedback"><?php echo $username_err; ?></span>
                  </div>

                  <div class="form-group">
                      <label>Password</label>
                      <input type="password" name="password" class="form-control <?php echo (!empty($password_err)) ? 'is-invalid' : ''; ?>" value="">
                      <span class="invalid-feedback"><?php echo $password_err; ?></span>
                  </div>

                  <div class="form-group">
                      <input type="submit" class="btn btn-primary" value="Login">
                      <input type="reset" class="btn btn-secondary ml-2" value="Reset">
                  </div>

              </form>
          </div>
        </div>
      </div>

    </div>

    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
  </body>
</html>

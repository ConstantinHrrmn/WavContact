<?php include "searchUser.php" ?>
<!-- Cette page permet de se connecter à WavMap -->
<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Ajout du lien avec bootstrap -->
   <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
   <meta charset="utf-8" name="viewport" content="width=device-width, initial-scale=1.0">
  </head>

  <body>
    <div class="container">
      <div class="row">
        <div class="col-sm-12" align="center">
          <img src="../../images/waview.png" alt="" style="width:10%">
          <h1>WavMap</h1>
        </div>
      </div>

      <hr>

      <div class="row">
        <div class="col-sm-12 d-flex justify-content-center">
          <div class="wrapper">
              <h2>Connexion</h2>
              <form action="" method="post">
                <!-- Adresse mail -->
                  <div class="form-group">
                      <label>Adresse mail</label>
                      <input type="text" name="username" class="form-control <?php echo (!empty($username_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $username; ?>">
                      <span class="invalid-feedback"><?php echo $username_err; ?></span>
                  </div>
                  <!-- Mot de passe -->
                  <div class="form-group">
                      <label>Mot de passe</label>
                      <input type="password" name="password" class="form-control <?php echo (!empty($password_err)) ? 'is-invalid' : ''; ?>" value="">
                      <span class="invalid-feedback"><?php echo $password_err; ?></span>
                  </div>
                  <!-- Boutons connexion et effacer -->
                  <div class="form-group">
                      <input type="submit" class="btn btn-primary" value="Connexion">
                      <input type="reset" class="btn btn-secondary ml-2" value="Effacer">
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

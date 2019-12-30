<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title><?=$this->getTitle()?></title>
    <link rel="stylesheet" href="<?=RESOURCES?>css/bootstrap.min.css" type="text/css">
    <script src="<?=RESOURCES?>js/bootstrap.min.js" type="text/javascript"></script>
    <script src="<?=RESOURCES?>js/jquery.slim.min.js" type="text/javascript"></script>
    <script src="<?=RESOURCES?>js/proper.min.js" type="text/javascript"></script>
    <?=$this->content('head')?>
  </head>
  <body>
      <?=$this->content('body')?>
  </body>
  <footer>
    <?=$this->content('footer')?>
  </footer>
</html>
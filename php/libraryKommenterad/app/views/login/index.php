<?php $this->start('head'); ?>
<?php $this->end(); ?>
<?php $this->start('body'); ?>
    <form action="<?=PUBLICPRO . 'App/Controllers/logincontroller/login'?>" method="post">
        <input type="text" name="username" id="username">
        <input type="password" name="password" id="password">
        <input type="submit" value="submit">
    </form>
<?php $this->end(); ?>
<?php $this->start('footer'); ?>
<meta content="test">
<?php $this->end(); ?>




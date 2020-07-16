<?php $this->start('head'); ?>
<?php $this->end(); ?>
<?php $this->start('body'); ?>
<div class="col-md-6 col-md-offset-3">
    <h3 class="text-center"><?=$this->viewData['page_header']?></h3><hr>
    <?= $this->html->table('library', $this->viewData['columns'], $this->viewData['values']) ?>
    <form class="form" action="<?=PUBLICPRO . 'App/Controllers/moviecontroller/add'?>" method="add">
    <?= $this->html->csrfInput() ?>
    <?= $this->html->submitBlock('Add',['class'=>'btn btn-primary btn-large'],['class'=>'text-right']) ?>
  </form>
</div>
<?php $this->end(); ?>
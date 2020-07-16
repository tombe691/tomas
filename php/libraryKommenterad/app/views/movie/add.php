<?php $this->start('head'); ?>
<?php $this->end(); ?>
<?php $this->start('body'); ?>
<div class="col-md-6 col-md-offset-3">
  <h3 class="text-center">Add</h3><hr>
  <form class="form" action="<?=PUBLICPRO . 'App/Controllers/moviecontroller/registeradd'?>" method="post">
    <?= $this->html->csrfInput() ?>
    <?= $this->html->displayErrors($this->displayErrors) ?>
    <?= $this->html->inputBlock('text','Title','title','',['class'=>'form-control'],['class'=>'form-group']) ?>
    <?= $this->html->inputBlock('text','Publish Date (d/m/y)','publish_date','' ,['class'=>'form-control'],['class'=>'form-group']) ?>
    <?= $this->html->checkboxBlock('Action','genre1',$this->viewData['genres']['Action'],[],['class'=>'form-group']) ?>
    <?= $this->html->checkboxBlock('Adventure','genre2',$this->viewData['genres']['Adventure'],[],['class'=>'form-group']) ?>
    <?= $this->html->checkboxBlock('Comedy','genre3',$this->viewData['genres']['Comedy'],[],['class'=>'form-group']) ?>
    <?= $this->html->checkboxBlock('Documentary','genre4',$this->viewData['genres']['Documentary'],[],['class'=>'form-group']) ?>
    <?= $this->html->checkboxBlock('Drama','genre5',$this->viewData['genres']['Drama'],[],['class'=>'form-group']) ?>
    <?= $this->html->checkboxBlock('Family','genre6',$this->viewData['genres']['Family'],[],['class'=>'form-group']) ?>
    <?= $this->html->checkboxBlock('Horror','genre7',$this->viewData['genres']['Horror'],[],['class'=>'form-group']) ?>
    <?= $this->html->checkboxBlock('Romance','genre8',$this->viewData['genres']['Romance'],[],['class'=>'form-group']) ?>
    <?= $this->html->checkboxBlock('Thriller','genre19',$this->viewData['genres']['Thriller'],[],['class'=>'form-group']) ?>
    <?= $this->html->textArea('Synopsis','synopsis','',5,3,['class'=>'form-control'],['class'=>'form-group']) ?>
    <?= $this->html->select('directors', 'directors', $this->viewData['directors'],[],3,[],['class'=>'form-group']) ?>
    <?= $this->html->submitBlock('Add',['class'=>'btn btn-primary btn-large'],['class'=>'text-right']) ?>
  </form>
  <h3 class="text-center">Add Director</h3><hr>
  <form class="form" action="<?=PUBLICPRO . 'App/Controllers/moviecontroller/registeradddirector'?>" method="post">
    <?= $this->html->csrfInput() ?>
    <?= $this->html->inputBlock('text','First Name','first_name','',['class'=>'form-control'],['class'=>'form-group']) ?>
    <?= $this->html->inputBlock('text','Last Name','last_name','' ,['class'=>'form-control'],['class'=>'form-group']) ?>
    <?= $this->html->submitBlock('Add',['class'=>'btn btn-primary btn-large'],['class'=>'text-right']) ?>
  </form>
</div>
<?php $this->end(); ?>

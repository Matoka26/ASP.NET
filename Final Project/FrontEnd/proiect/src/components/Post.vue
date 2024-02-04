
<template>
  <div class="postare">
    <p>{{ usr }}</p>
    <p>{{ picture }}</p>
    <p>{{ description }}</p>
  </div>

</template>



<script>
import {onMounted, ref} from "vue";

export default{
  name: 'Post',
  props: ['username','picture','description'],
  setup(props){
    const picture = ref('');
    const description = ref('');
    const usr = ref('');

    onMounted(async() =>{
      try{
        usr.value = props.username;
        picture.value = props.picture;
        description.value = props.description;

      }catch (error){
        console.log(error)
      }
    })

    return { picture, usr, description};
  }
}

</script>

<style scoped>
.postare{
  background-color: #282828;
  margin: 10px;
  border: 1px solid black;
  padding: 10px 20px;
}
</style>
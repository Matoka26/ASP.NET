
<template>
  <div class="postare">
    <p>{{ username }}</p>
    <p>{{ picture }}</p>
    <p>{{ description }}</p>
  </div>

</template>



<script>
import {onMounted, ref} from "vue";

export default{
  name: 'Post',
  props: ['username','picture','description'],
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
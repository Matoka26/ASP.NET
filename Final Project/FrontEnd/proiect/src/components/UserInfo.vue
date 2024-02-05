<template>
  <div class="info">
    <p><h1>{{ username }}</h1></p>
    <p>{{ profilePic }}</p>
    <p>{{ coverPic }}</p>
    <p>{{ snippet(bio) }}</p>
  </div>

</template>

<script>

export default{
  name: 'Post',
  props: ['username','profilePic','coverPic','bio'],
  methods: {
    /// THIS IS A PIPE
    snippet(value){
       if(value.length > 100)
         return value.slice(0,100) + '...';
      return value;
    },
  },
};
</script>

<style scoped>
.info{
  background-color: #282828;
  margin: 10px;
  border: 1px solid black;
  padding: 10px 20px;
}
</style>
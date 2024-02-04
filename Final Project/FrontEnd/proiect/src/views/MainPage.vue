<template>
  <div class="profile-page">
    <NavBar name="Animal Glimpse" />

      <div class="posts">
        <ul>
          <li v-for="item in items" :key="item.id">
            <Post :username="item.username" :description="item.description" :picture="item.picture" />
          </li>
        </ul>
      </div>

    </div>
</template>

<script>

import {defineComponent, onMounted, ref} from "vue";
import NavBar from "@/components/NavBar.vue";
import Post from "@/components/Post.vue";
import {foundProfile, foundUser, getFeed, getPostsOfUser} from "@/Helpers/Axios.ts";

export default defineComponent({
  components: {Post, NavBar},
  setup(){
    const items = ref([]);

    onMounted(async () =>{
      try{
        items.value = await getFeed();

      }catch (error){
        console.error("Error fetching:", error);
      }
    });
    return {items};
  }
})
</script>

<style scoped>

</style>

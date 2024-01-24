<script setup lang="ts">
const props = defineProps<{
  id: string
  name: string
}>()
</script>

<template>
  <div class="flex flex-col justify-between">
    <h1>{{ props.name }}</h1>
    <p>{{ props.id }}</p>
  </div>
</template>

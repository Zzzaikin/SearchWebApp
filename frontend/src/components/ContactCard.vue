<template>
  <div>
    <p class="my-3">
      <span class="parameter-title">Польза продукта: </span>
      <span class="ml-2">{{ application.contactFullName }}</span>
    </p>
  </div>
</template>

<script>
import CompleteStageSlider from "./CompleteStageSlider.vue";
import Filters from "./Filters.vue";
export default {
  props: ["application"],
};
</script>
<style scoped>
::v-deep .v-card__text {
  font-size: 18px !important;
  color: black !important;
}
.image {
  margin-left: 26px;
}
.wr {
  display: flex;
  flex-direction: row;
  margin-left: 12px;
}
.aa {
  max-height: 40px;
  max-width: 500px;
  text-overflow: ellipsis;
  white-space: nowrap;
  overflow: hidden;
}
.application-title {
  font-weight: 600;
}
.application-title-wrapper {
  width: 60%;
  text-overflow: ellipsis;
  white-space: nowrap;
  overflow: hidden;
}
</style>
<template>
  <div>
    <v-card class="mx-auto" elevation="0" outlined>
      <v-card-text>
        <v-row class="ma-0 my-3">
          <p class="text-h4 text--primary">{{ title }}</p>
          <div class="image">
            <v-img
              max-height="120"
              max-width="170"
              src="https://picsum.photos/id/11/500/300"
            ></v-img>
          </div>
        </v-row>
        <div>
          <div class="parameters mt-4">
            <v-row class="my-3 wr">
              <span class="parameter-title">Стадия готовности: </span>
              <!--   <span class="ml-2">{{ completeStage }}</span> -->
              <CompleteStageSlider></CompleteStageSlider>
            </v-row>
            <p class="my-3">
              <span class="parameter-title"
                >Кейсы использования продукта:
              </span>
              <span class="ml-2">{{ useCases }}</span>
            </p>
            <p class="my-3">
              <span class="parameter-title">Наличие пилотного проекта: </span>
              <span class="ml-2">{{ pilotProjectExists }}</span>
            </p>
            <p class="my-3">
              <span class="parameter-title">Польза продукта: </span>
              <span class="ml-2">{{ productBenefits }}</span>
            </p>
            <p>
              <span class="parameter-title">Краткое описание: </span>
              <span class="ml-2">{{ shortDescription }}</span>
            </p>
          </div>
        </div>
      </v-card-text>
      <v-card-actions>
        <v-btn text color="primary" @click="goToApplication"> Подробнее </v-btn>
      </v-card-actions>
    </v-card>
  </div>
</template>

<script>
import CompleteStageSlider from "./CompleteStageSlider.vue";
import Filters from "./Filters.vue";
export default {
  props: [
    "id",
    "title",
    "completeStage",
    "useCases",
    "certificationNeed",
    "pilotProjectExists",
    "productBenefits",
    "shortDescription",
  ],
  components: { Filters, CompleteStageSlider },
  data: () => ({}),
  methods: {
    goToApplication() {
      this.$router.push(`/application/${this.id}`);
    },
  },
};
</script>
<style scoped>
::v-deep .v-card__text {
  font-size: 16px !important;
  color: black !important;
}
.image {
  margin-left: 26px;
}
.wr {
  display: flex;
  flex-direction: row;
}
</style>
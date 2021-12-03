<template>
  <div>
    <v-card class="mx-auto" elevation="0" outlined>
      <v-card-text>
        <v-row class="ma-0 my-3" justify="space-between">
          <div class="application-title-wrapper">
            <span
              :title="title"
              class="text-h5 text--primary application-title"
              >{{ title }}</span
            >
          </div>
          <div class="image">
            <v-img
              max-height="MAX_SYMBOLS"
              max-width="170"
              src="https://picsum.photos/id/11/500/300"
            ></v-img>
          </div>
        </v-row>
        <div>
          <div class="parameters mt-4">
            <CompleteStageSlider
              :completeStage="completeStage"
            ></CompleteStageSlider>
            <p class="my-3">
              <span class="parameter-title"
                >Кейсы использования продукта:
              </span>
              <span class="ml-2">{{
                useCases.length > MAX_SYMBOLS
                  ? useCases.slice(0, MAX_SYMBOLS) + "..."
                  : useCases
              }}</span>
            </p>
            <p class="my-3">
              <span class="parameter-title">Наличие пилотного проекта: </span>
              <span class="ml-2">{{
                pilotProjectExists.length > MAX_SYMBOLS
                  ? pilotProjectExists.slice(0, MAX_SYMBOLS) + "..."
                  : pilotProjectExists
              }}</span>
            </p>
            <p class="my-3">
              <span class="parameter-title">Польза продукта: </span>
              <span class="ml-2">{{
                productBenefits.length > MAX_SYMBOLS
                  ? productBenefits.slice(0, MAX_SYMBOLS) + "..."
                  : productBenefits
              }}</span>
            </p>
            <p>
              <span class="parameter-title">Краткое описание: </span>
              <span class="ml-2">{{
                shortDescription.length > MAX_SYMBOLS
                  ? shortDescription.slice(0, MAX_SYMBOLS) + "..."
                  : shortDescription
              }}</span>
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
  data: () => ({
    MAX_SYMBOLS: 120,
  }),
  methods: {
    goToApplication() {
      this.$router.push(`/application/${this.id}`);
    },
  },
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
  smargin-left: 12px;
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